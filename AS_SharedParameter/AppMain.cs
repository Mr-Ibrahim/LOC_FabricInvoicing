using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AS_SharedParameter
{
    public class AppMain
    {
        public static AppMain AppObject { get; private set; }
        public DatabasesTypes DatabaseAction { get; private set; }
        public AppMain() 
        {
            AppObject = this;
            DatabaseAction = new DatabasesTypes();
        }
    }
}
