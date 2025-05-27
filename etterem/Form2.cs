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
            pizzauj picca = new pizzauj();
            picca.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            szosz sos = new szosz();
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

        private void oldalHáttérszíneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true; // Teljes színpaletta 

            colorDialog1.ShowHelp = true; // Segítség gomb megjelenítése
            colorDialog1.Color = Color.Red; // Alapértelmezett szín beállítása
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                MessageBox.Show($"Selected color: {selectedColor}");
                this.BackColor = selectedColor;


            }

        }

        private void betűFormázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                // If the user selects a font and clicks OK
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Loop through all controls on the form
                    foreach (Control control in this.Controls)
                    {
                        // Apply the selected font to each control that supports it
                        listBox1.Font = fontDialog.Font;
                        
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Title = "Save a file";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                MessageBox.Show($"File saved to: {filePath}");
            }


        }
    }
}

