using System.IO;
using System.Windows.Forms;
using System.Xml;
using AS_SQLAccessLogic;
using AS_ExceptionHandler;

namespace LOC_FabricInvoicing.BusinessLogic
{
    public static class Security
    {
        static AS_SharedParameter.AppMain AppObject { get { return AS_SharedParameter.AppMain.AppObject; } }
        public static void LoadLicense()
        {
            StreamReader _StreamReader;
            XmlDocument _XmlDocument;
            string DocumentPath;

            try
            {
                DocumentPath = Path.GetFullPath(Application.StartupPath + "\\FrameWorkServerSupportWin64.xml");

                if (File.Exists(DocumentPath) == true)
                {
                    _StreamReader = new StreamReader(DocumentPath);
                    _XmlDocument = new XmlDocument();

                    _XmlDocument.LoadXml(_StreamReader.ReadToEnd());

                    AppObject.DatabaseAction.ReadAndWrite = new DatabaseInitialization(
                        _XmlDocument.SelectNodes("//junaidjamshed/representative/readandwrite/dxserver")[0].InnerText,
                        _XmlDocument.SelectNodes("//junaidjamshed/directories/ldb")[0].InnerText,
                        _XmlDocument.SelectNodes("//junaidjamshed/credentials/dxuser")[0].InnerText,
                        _XmlDocument.SelectNodes("//junaidjamshed/credentials/dxpassword")[0].InnerText
                        );
                }
            }
            catch (AS_Exception x)
            {
                MessageBox.Show(x.Message, "Error while loading License.", MessageBoxButtons.OK);
            }
        }
    }
}
