using System;
using System.Windows.Forms;
using AS_SharedParameter;
using LOC_FabricInvoicing.BusinessLogic;

namespace LOC_FabricInvoicing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppMain AppObject = new AppMain();
            Security.LoadLicense();
            Application.Run(new ApplicationForms.Frm_Splash());
        }
    }
}
