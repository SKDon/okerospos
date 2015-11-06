using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OBS.Pos.UI.Shared.Extensions
{
    public static class FormExtensions
    {
        public static void LoadContext(this Form formComponent, BindingSource bindingSource, EventHandler saveMethod)
        {
            ChangeContext.Instance.LoadContext(formComponent, bindingSource, saveMethod);
        }

        /// <summary>
        /// Call the system Authorization Module (SecurityContext)
        /// </summary>
        /// <param name="formComponent"></param>
        /// <param name="menus"></param>
        public static void AuthorizeAll(this Form formComponent, ToolStripItemCollection menus)
        {
            SecurityContext.Instance.AuthorizeAll(menus);
        }
        public static void ResetChangeState(this Form formComponent)
        {
            var changeState = ChangeContext.Instance.ChangeStates[formComponent.Name];
            if (changeState != null)
            { 
                changeState.IsBindingActive = true;
                changeState.DataChanged(new object(), new EventArgs());  
            }
        }
        public static void MarkDirty(this Form formComponent, bool isDirty)
        {
            formComponent.Text = formComponent.Text.Replace("*", "");
            formComponent.Text += isDirty ? "*" : "";
        }
    }
}
