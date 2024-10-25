using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Repairs
{
    internal class Sabit_Kodlar
    {
        public static SqlConnection conn = new SqlConnection("Data Source=VOLQAN\\SQLEXPRESS;Initial Catalog=Clock_Repairs;Integrated Security=True");
        public static String time = DateTime.Now.ToString();
    }
}
