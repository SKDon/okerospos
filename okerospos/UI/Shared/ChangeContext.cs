using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBS.Pos.UI.Shared.Extensions;

namespace OBS.Pos.UI.Shared
{
    public class ChangeContext
    {

        public enum DataModes
        {
            Unknown = 0,
            Dirty = 1
        }

        #region ChangeState
        public class ChangeState
        {
            #region private members
            private DataModes _dataMode = DataModes.Unknown;
            private Form _formComponent = null;
            private EventHandler _saveMethod = null;
            private Timer _SwitchRecordsTimer = null;
            #endregion

            #region properties
            public bool IsBindingActive
            {
                get;
                set;
            }
            public bool IsSwitchingRecords
            {
                get;
                set;
            }
            public DataModes DataMode
            {
                get { return _dataMode; }
            }

            internal ChangeState(Form formComponent, BindingSource bindingSource, EventHandler saveMethod)
            {
                _formComponent = formComponent;
                _saveMethod = saveMethod;
                _SwitchRecordsTimer = new Timer();
                _SwitchRecordsTimer.Interval = 250;
                _SwitchRecordsTimer.Tick += _SwitchRecordsTimer_Tick;
                _SwitchRecordsTimer.Enabled = false;

                IsBindingActive = true;
                AttachDataChangeHandler(formComponent.Controls);
                AttachDataBindingHandler(bindingSource);
                AttachFormClosingHandler(formComponent);
            }
            #endregion

            #region Event Handler attachment
            private void AttachDataBindingHandler(BindingSource bindingSource)
            {
                foreach (Binding binding in bindingSource.CurrencyManager.Bindings)
                {
                    if (!(binding.Control is ListBox))
                        binding.BindingComplete += BindingComplete;
                }
            }
            private void AttachDataChangeHandler(Control.ControlCollection controls)
            {
                foreach (Control ctl in controls)
                {
                    if ((ctl is Panel) || (ctl is TabControl) || (ctl is TabPage) || (ctl is GroupBox))
                    { AttachDataChangeHandlerInner(ctl); }
                    else
                    {
                        AttachDataChangeHandler(ctl.Controls);
                    }
                }
            }
            private void AttachDataChangeHandlerInner(Control control)
            {
                foreach (Control ctl in control.Controls)
                {
                    if ((ctl is Panel) || (ctl is TabControl) || (ctl is TabPage) || (ctl is GroupBox))
                    {
                        AttachDataChangeHandlerInner(ctl);
                    }
                    else
                    {
                        if ((ctl is TextBox))
                        { ((TextBox)ctl).TextChanged += DataChanged; }
                        else if ((ctl is CheckBox))
                        { ((CheckBox)ctl).CheckedChanged += DataChanged; }
                        else if ((ctl is RadioButton))
                        { ((RadioButton)ctl).CheckedChanged += DataChanged; }
                        else if ((ctl is ComboBox))
                        {
                            ((ComboBox)ctl).SelectedValueChanged += DataChanged;
                        }
                        else if ((ctl is ListBox)) //special case
                        {
                            ((ListBox)ctl).SelectedValueChanged += ListDataChanged;
                        }
                    }
                }
            }
            private void AttachFormClosingHandler(Form formComponent)
            {
                formComponent.FormClosing += FormClosing;
            }
            #endregion

            #region Central Event Handling
            public void DataChanged(object sender, EventArgs e)
            {
                _dataMode = (!IsBindingActive && !IsSwitchingRecords) ? DataModes.Dirty : DataModes.Unknown;
                if (_formComponent != null)
                    _formComponent.MarkDirty(_dataMode == DataModes.Dirty);
            }
            public void ListDataChanged(object sender, EventArgs e)
            {
                IsSwitchingRecords = true;
                _SwitchRecordsTimer.Enabled = true;
            }
            private void _SwitchRecordsTimer_Tick(object sender, EventArgs e)
            {
                IsSwitchingRecords = false;
            }
            public void FormClosing(object sender, FormClosingEventArgs e)
            {
                if (_dataMode == DataModes.Dirty)
                {
                    DialogResult result = MessageBox.Show("Save changes before closing this Screen?", "Close Screen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (_saveMethod != null)
                        {
                            _saveMethod.Invoke(new object(), new EventArgs());
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            public void BindingComplete(object sender, EventArgs e)
            {
                IsBindingActive = false;
            }
            #endregion
        }
        #endregion

        #region private members

        private Dictionary<string, ChangeState> _formChangeStates;
        private static ChangeContext _instance;

        #endregion

        #region properties
        public static ChangeContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChangeContext();
                    _instance._formChangeStates = new Dictionary<string, ChangeState>();
                }

                return _instance;
            }
        }

        public Dictionary<string, ChangeState> ChangeStates
        {
            get { return _formChangeStates; }
        }


        #endregion
        public void LoadContext(Form formComponent, BindingSource bindingSource, EventHandler saveMethod)
        {
            if (_formChangeStates.Keys.Contains(formComponent.Name))
            {
                _formChangeStates.Remove(formComponent.Name);
            }

            ChangeState thisState = new ChangeState(formComponent, bindingSource, saveMethod);
            _formChangeStates.Add(formComponent.Name, thisState);

        }

    }
}
