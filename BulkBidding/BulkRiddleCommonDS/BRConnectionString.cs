using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRiddleCommonDS

{
    public class BRConnectionString
    {
        public static string GetConnectionString
        {
            get { return "Data Source=DESKTOP-DO5OUG1\\SQLEXPRESS;Database=BulkBidding;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"; }
        }
    }
}
