using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace OBS.Pos.UI.Shared
{
    public class SecurityContext
    {
        public class SecurityItem
        {
            #region private members
            private Form _formComponent = null;
            #endregion

            public SecurityItem(Form formComponent)
            {
                _formComponent = formComponent;
            }
        }
        #region private members
        private static SecurityContext _Instance = null;

        #endregion

        public SecurityContext()
        {

        }

        public static SecurityContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SecurityContext();
                }
                return _Instance;
            }
        }

        /// <summary>
        /// Centralized authorization of application system.
        /// </summary>
        /// <param name="menu"></param>
        public void AuthorizeAll(ToolStripItemCollection menus)
        {
            //MessageBox.Show(DefaultAdminAclXML);
            //MessageBox.Show(DefaultUserAclXML);
        }

        /// <summary>
        /// Returns an XML string which stores the default list of forms that 
        /// can be accessed by any user. this is used in create an ACL for 
        /// a particular user role.
        /// </summary>
        /// <returns></returns>
        public string DefaultAdminAclXML
        {
            get
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                if (asm != null && asm.FullName.Contains("okerospos"))
                {
                    Type[] alltype = asm.GetTypes();
                    if (alltype != null)
                    {
                        //Root element
                        var xmlRoot = new XElement("security",
                        from f in alltype
                        where f.BaseType == typeof(Form)
                        select new XElement("resource",
                            new XAttribute("name", f.FullName),
                            new XAttribute("enabled", true.ToString())
                            ));
                        return xmlRoot.ToString();
                    }
                }

                return string.Empty;
            }

        }
        public string DefaultUserAclXML
        {
            get
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                if (asm != null && asm.FullName.Contains("okerospos"))
                {
                    Type[] alltype = asm.GetTypes();
                    if (alltype != null)
                    {
                        //Root element
                        var xmlRoot = new XElement("security",
                        from f in alltype
                        where f.BaseType == typeof(Form)
                        select new XElement("resource",
                            new XAttribute("name", f.FullName),
                            new XAttribute("enabled", (!IsContainedIn(SettingsHelper.GetSetting(SettingKeys.DEFAULT_USER_INCLUDECLASSNAMES), f.Name)).ToString())
                                ));
                        return xmlRoot.ToString();
                    }
                }

                return string.Empty;
            }

        }

        private bool IsContainedIn(string searchTerm, string expression)
        {
            string[] terms = searchTerm.Split(',');
            foreach (string term in terms)
            {
                if (expression.Contains(term)) return true;
            }

            return false;
        }
    }


}
