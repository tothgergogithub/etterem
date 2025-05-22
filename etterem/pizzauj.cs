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
    public partial class pizzauj : Form
    {
        public pizzauj()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "Sajtos Pizza";
            label22.Text = "4500 Ft";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Text = "Sonkás Pizza";
            label22.Text = "4000 Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = "Son goku";
            label22.Text = "3000 Ft";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label14.Text = "Vegán pizza";
            label22.Text = "3200 Ft";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label14.Text = "Hawaii pizza";
            label22.Text = "3500 Ft";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label14.Text = "Olasz Pizza";
            label22.Text = "3200 Ft";    
                
        }
    }
}
