using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {

        private static string cName = "Data Source= APEX-75.;  Initial Catalog=StudentManagement;Integrated Security=false;Trusted_Connection=yes;";

        public static string CName { get => cName; }
    }
}
