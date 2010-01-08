using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using libSnarlStyles;
using Microsoft.Win32;
using System.Reflection;
using System.Windows.Interop;
using prefs_kit_d2;
using Winkle;

namespace hover
{

    [Guid("74D1797C-E7DD-4330-80CF-F628477142A9"), ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual), ComSourceInterfaces(typeof(libSnarlStyles.IStyleEngine))]
    [ProgId("hover.styleengine")]    
    public class styleengine : IStyleEngine
    {
        public styleengine() {
            Winkle.VersionCheck myUpdateChecker = new Winkle.VersionCheck("Hover", "http://tlhan-ghun.de/files/hover.xml");
            Winkle.UpdateInfo myUpdateResponse = myUpdateChecker.checkForUpdate(System.Reflection.Assembly.GetExecutingAssembly(), false);
        }


        #region IStyleEngine Members

        [ComVisible(true)]
        int IStyleEngine.CountStyles()
        {
            return 1;
        }

        [ComVisible(true)]
        IStyleInstance IStyleEngine.CreateInstance(string StyleName)
        {
            StyleInstance myInstance = new StyleInstance();
            return myInstance;

        }

        [ComVisible(true)]
        string IStyleEngine.Date()
        {
            return "2010-01-07";
        }

        [ComVisible(true)]
        string IStyleEngine.Description()
        {
            return "Shows a semitransparent rectangle on the center of the screen";
        }

        [ComVisible(true)]
        int IStyleEngine.GetConfigWindow(string StyleName)
        {
            return 0;
        }

        [ComVisible(true)]
        melon.M_RESULT IStyleEngine.Initialize()
        {
            return melon.M_RESULT.M_OK;
        }

        [ComVisible(true)]
        string IStyleEngine.LastError()
        {
            return "Undefined error";
        }

        [ComVisible(true)]
        string IStyleEngine.Name()
        {
            return "Hover";

        }

        [ComVisible(true)]
        string IStyleEngine.Path()
        {
            return Assembly.GetExecutingAssembly().CodeBase;
       
        }

        [ComVisible(true)]
        int IStyleEngine.Revision()
        {
            return 1;
        }

        [ComVisible(true)]
        void IStyleEngine.StyleAt(int Index, ref style_info Style)
        {
            string pathToIcon = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase) + "\\hover.ico";
            pathToIcon = pathToIcon.Replace("file:\\", "");

            Style.Flags = S_STYLE_FLAGS.S_STYLE_SINGLE_INSTANCE;
            Style.IconPath = pathToIcon;
            Style.Major = Assembly.GetExecutingAssembly().GetName().Version.Major;
            Style.Minor = Assembly.GetExecutingAssembly().GetName().Version.Minor;
            Style.Name = "Hover";
            Style.Path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "");
            Style.Schemes = "Icon only|Title|Text|Meter";
            Style.Copyright = "Tlhan Ghun 2010";
            Style.SupportEmail = "info@tlhan-ghun.de";
            Style.URL = "http://tlhan-ghun.de/";
            Style.Description = "Shows a semitransparent rectangle on the center of the screen";
        }

        [ComVisible(true)]
        void IStyleEngine.TidyUp()
        {
            return;
        }

        [ComVisible(true)]
        int IStyleEngine.Version()
        {
            return 39;
        }

        #endregion

        #region COM Registration Methods


        [ComRegisterFunction()]
        public static void RegisterClass(string key)
        {
            StringBuilder skey = new StringBuilder(key);
            skey.Replace(@"HKEY_CLASSES_ROOT\", "");
            RegistryKey regKey = Registry.ClassesRoot.OpenSubKey(skey.ToString(), true);
            RegistryKey ctrl = regKey.CreateSubKey("Control");
            ctrl.Close();
            RegistryKey inprocServer32 = regKey.OpenSubKey("InprocServer32", true);
            inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
            inprocServer32.Close();
            regKey.Close();
        }


        [ComUnregisterFunction()]
        public static void UnregisterClass(string key)
        {
            StringBuilder skey = new StringBuilder(key);
            skey.Replace(@"HKEY_CLASSES_ROOT\", "");
            RegistryKey regKey = Registry.ClassesRoot.OpenSubKey(skey.ToString(), true);
            regKey.DeleteSubKey("Control", false);
            RegistryKey inprocServer32 = regKey.OpenSubKey("InprocServer32", true);
            regKey.DeleteSubKey("CodeBase", false);
            regKey.Close();
        }
        #endregion
    }
}