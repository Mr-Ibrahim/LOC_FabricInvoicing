using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AS_SQLAccessLogic;

namespace AS_SharedParameter
{
    public class DatabasesTypes
    {
        public DatabaseInitialization ReadOnly { get; set; }
        public DatabaseInitialization WriteOnly { get; set; }
        public DatabaseInitialization ReadAndWrite { get; set; }
    }
}
