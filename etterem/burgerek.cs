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
    public partial class burgerek : Form
    {
        public burgerek()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rendelés rendel=new rendelés();
            rendel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = "Sajtburger";
            label17.Text = "2000 Ft";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "Duplasajtburger";
            label17.Text = "2500 Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = "Grander";
            label17.Text = "3000 Ft";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = "Fekete burger";
            label17.Text = "4000 Ft";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = "Marhaburger";
            label17.Text = "3500 Ft";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = "Grillburger";
            label17.Text = "2000 Ft";
        }
    }
}
