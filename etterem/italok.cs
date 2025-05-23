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
    public partial class italok : Form
    {
        public italok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "Víz";
            label17.Text = "800 Ft";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Text = "Kóla";
            label17.Text = "1200 Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = "Fanta";
            label17.Text = "1000 Ft";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label14.Text = "Sprite";
            label17.Text = "1000 Ft";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label14.Text = "Gyümölcs lé";
            label17.Text = "800 Ft";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label14.Text = "Sőr";
            label17.Text = "1500 Ft";
        }
    }
}
