namespace etterem
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdőoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyiségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kosárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(698, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(102, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 57;
            this.pictureBox8.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőoldalToolStripMenuItem,
            this.rendelésToolStripMenuItem,
            this.mennyiségToolStripMenuItem,
            this.kosárToolStripMenuItem,
            this.leadásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 57);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kezdőoldalToolStripMenuItem
            // 
            this.kezdőoldalToolStripMenuItem.Name = "kezdőoldalToolStripMenuItem";
            this.kezdőoldalToolStripMenuItem.Size = new System.Drawing.Size(77, 53);
            this.kezdőoldalToolStripMenuItem.Text = "Kezdőoldal";
            // 
            // rendelésToolStripMenuItem
            // 
            this.rendelésToolStripMenuItem.Name = "rendelésToolStripMenuItem";
            this.rendelésToolStripMenuItem.Size = new System.Drawing.Size(66, 53);
            this.rendelésToolStripMenuItem.Text = "Rendelés";
            // 
            // mennyiségToolStripMenuItem
            // 
            this.mennyiségToolStripMenuItem.Name = "mennyiségToolStripMenuItem";
            this.mennyiségToolStripMenuItem.Size = new System.Drawing.Size(77, 53);
            this.mennyiségToolStripMenuItem.Text = "Mennyiség";
            // 
            // kosárToolStripMenuItem
            // 
            this.kosárToolStripMenuItem.Name = "kosárToolStripMenuItem";
            this.kosárToolStripMenuItem.Size = new System.Drawing.Size(48, 53);
            this.kosárToolStripMenuItem.Text = "Kosár";
            // 
            // leadásToolStripMenuItem
            // 
            this.leadásToolStripMenuItem.Name = "leadásToolStripMenuItem";
            this.leadásToolStripMenuItem.Size = new System.Drawing.Size(55, 53);
            this.leadásToolStripMenuItem.Text = "Leadás";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(287, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Kosár tartalma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 238);
            this.listBox1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 46);
            this.button1.TabIndex = 60;
            this.button1.Text = "Fizetés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 46);
            this.button2.TabIndex = 61;
            this.button2.Text = "Vissza";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdőoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyiségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kosárToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadásToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}