namespace etterem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdőoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyiségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kosárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőoldalToolStripMenuItem,
            this.rendelésToolStripMenuItem,
            this.mennyiségToolStripMenuItem,
            this.kosárToolStripMenuItem,
            this.leadásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kezdőoldalToolStripMenuItem
            // 
            this.kezdőoldalToolStripMenuItem.Name = "kezdőoldalToolStripMenuItem";
            this.kezdőoldalToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kezdőoldalToolStripMenuItem.Text = "Kezdőoldal";
            // 
            // rendelésToolStripMenuItem
            // 
            this.rendelésToolStripMenuItem.Name = "rendelésToolStripMenuItem";
            this.rendelésToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rendelésToolStripMenuItem.Text = "Rendelés";
            // 
            // mennyiségToolStripMenuItem
            // 
            this.mennyiségToolStripMenuItem.Name = "mennyiségToolStripMenuItem";
            this.mennyiségToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mennyiségToolStripMenuItem.Text = "Mennyiség";
            // 
            // kosárToolStripMenuItem
            // 
            this.kosárToolStripMenuItem.Name = "kosárToolStripMenuItem";
            this.kosárToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.kosárToolStripMenuItem.Text = "Kosár";
            // 
            // leadásToolStripMenuItem
            // 
            this.leadásToolStripMenuItem.Name = "leadásToolStripMenuItem";
            this.leadásToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.leadásToolStripMenuItem.Text = "Leadás";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(91, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Itt fogyasztom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(437, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "elviszem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdőoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyiségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kosárToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadásToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

