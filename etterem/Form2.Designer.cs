namespace etterem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.kezdőoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyiségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kosárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(171, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "kategória nevek";
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
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(698, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(574, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Következő";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem kezdőoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyiségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kosárToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadásToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}