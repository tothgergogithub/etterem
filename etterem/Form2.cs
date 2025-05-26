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
    public partial class rendelés : Form
    {
        public rendelés()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void rendelés_Load(object sender, EventArgs e)
        {

        }

        private void kezdőoldalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mennyiségToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kosárToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leadásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           pizzauj picca=new pizzauj();
           picca.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            szosz sos=new szosz();
            sos.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            burgerek burgerek = new burgerek();
            burgerek.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            italok italok = new italok();
            italok.ShowDialog();

        }
    }
}
