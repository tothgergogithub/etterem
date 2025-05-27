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

    
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;
            string pass = textBox3.Text;

            string connStr = "server=localhost;user=root;database=etterem;port=3306;password=";

            //adatbázis kapcsolat létrehozása

            MySqlConnection conn = new MySqlConnection(connStr);

            try

            {



                conn.Open();

                //sql parancs – visszatérési érték nincs!!!

                string sql = $"INSERT INTO `felhasznalok`(`ID`, `username`, `email`, `password`) VALUES ('','{username}', '{email}', '{pass}')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //parancs végrehajtása

                if (username != "" && email != "" && pass != "" && email.Contains("@"))
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sikeres regisztráció!");
                    rendelés rend = new rendelés();
                    rend.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Hiba!");
                }
               
            }


            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());

            }

            finally
            {
                conn.Close();
            }

        }
    }
}
