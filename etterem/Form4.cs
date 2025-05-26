using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etterem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Filter tulajdonság a menthető fájltípusok megadásához
            saveFileDialog1.Filter = "Szöveges fájl (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            //DefaultExt tulajdonságot az alapértelmezett fájlkiterjesztés megadásához
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Fájl mentése a saveFileDialog1.FileName útvonalra
                System.IO.File.WriteAllText(saveFileDialog1.FileName, "Mentett szöveg");
            }
           
        }
    }
}
