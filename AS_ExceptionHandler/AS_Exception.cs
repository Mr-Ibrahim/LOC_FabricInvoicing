using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace AS_ExceptionHandler
{
    public class AS_Exception : Exception
    {
        public AS_Exception() { }

        public int LineID { get; set; }
        public string GridName { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorField { get; set; }
        public string Outlet { get; set; }
        public string LoginUser { get; set; }
        public DateTime ErrorTime { get; set; }
        public string EmbedError { get; set; }

        public AS_Exception(string _Message)
        {
            this.ErrorMessage = _Message;
            this.LoginUser = WindowsIdentity.GetCurrent().Name;
            this.ErrorTime = DateTime.Now;
        }
        public AS_Exception(string _Message, String _FieldName, string _LoginUser, string _DateTime)
        {
            this.ErrorMessage = _Message;
            this.ErrorField = _FieldName;
            this.LoginUser = WindowsIdentity.GetCurrent().Name;
            this.ErrorTime = DateTime.Now;
        }
        public AS_Exception(string _Message, String _FieldName, string _GridName, int _LineID, string _LoginUser, string _DateTime)
        {
            this.ErrorMessage = _Message;
            this.ErrorField = _FieldName;
            this.LineID = _LineID;
            this.GridName = _GridName;
            this.LoginUser = WindowsIdentity.GetCurrent().Name;
            this.ErrorTime = DateTime.Now;
        }
        public void EmbedErrorToDB() 
        {
            EmbedError = string.Format(@"INSERT INTO [AX_Link].[dbo].[xUtil_ErrorLog] ([Shop_ID], [DateTime], [LoginUser], [Error]) VALUES('{0}', '{1}', '{2}', '{3}')", Outlet, ErrorTime, LoginUser, ErrorMessage);
        }
    }
}
