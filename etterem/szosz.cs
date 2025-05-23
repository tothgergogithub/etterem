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
    public partial class szosz : Form
    {
        public szosz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Ketchup";
            label11.Text = "800 Ft";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Mustár";
            label11.Text = "600 Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Majonéz";
            label11.Text = "500 Ft";
        }
    }
}
