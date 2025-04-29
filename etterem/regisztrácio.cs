using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace etterem
{
    public partial class regisztrácio : Form
    {

        public regisztrácio()
        {
            InitializeComponent();

        }
        public class Tutorial4
        {
            public static void Main()
            {
                string connStr = "ser-ver=localhost;user=root;database=world;port=3306;password=******";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    //sql parancs, melynek egy visszatérési értéke van
                    string sql = "SELECT COUNT(*) FROM Country";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //eredmény ertárolása a result változóba
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int r = Convert.ToInt32(result);
                        Console.WriteLine("Number of countries in the world database is: " + r);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
                Console.WriteLine("Done.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
