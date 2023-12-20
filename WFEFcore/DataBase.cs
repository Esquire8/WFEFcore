using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFEFcore
{
    internal class DataBase
    {
        public static string connectionString 
        { 
            get 
            {
                return (@"Server=SERGEY;Database=TestDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            } 
        }
    }
}
