namespace Password_Security_Tester___Bruteforce
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
            this.components = new System.ComponentModel.Container();
            this.utilsDragControl1 = new Utils.Framework.UtilsDragControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utilsLabel2 = new Utils.Framework.utilsLabel();
            this.utilsLabel1 = new Utils.Framework.utilsLabel();
            this.utilsSeparateLine1 = new Utils.Framework.utilsSeparateLine();
            this.utilsSeparateLine2 = new Utils.Framework.utilsSeparateLine();
            this.utilsFlatButton1 = new Utils.Framework.utilsFlatButton();
            this.utilsFlatButton2 = new Utils.Framework.utilsFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.utilsLabel3 = new Utils.Framework.utilsLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.utilsLabel4 = new Utils.Framework.utilsLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.utilsLabel5 = new Utils.Framework.utilsLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // utilsDragControl1
            // 
            this.utilsDragControl1.DragControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.utilsLabel2);
            this.panel1.Controls.Add(this.utilsLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 70);
            this.panel1.TabIndex = 1;
            // 
            // utilsLabel2
            // 
            this.utilsLabel2.AutoSize = true;
            this.utilsLabel2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel2.Location = new System.Drawing.Point(827, 9);
            this.utilsLabel2.Name = "utilsLabel2";
            this.utilsLabel2.Size = new System.Drawing.Size(18, 25);
            this.utilsLabel2.TabIndex = 2;
            this.utilsLabel2.Text = "-";
            this.utilsLabel2.Click += new System.EventHandler(this.utilsLabel2_Click);
            // 
            // utilsLabel1
            // 
            this.utilsLabel1.AutoSize = true;
            this.utilsLabel1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel1.Location = new System.Drawing.Point(851, 9);
            this.utilsLabel1.Name = "utilsLabel1";
            this.utilsLabel1.Size = new System.Drawing.Size(25, 25);
            this.utilsLabel1.TabIndex = 0;
            this.utilsLabel1.Text = "X";
            this.utilsLabel1.Click += new System.EventHandler(this.utilsLabel1_Click);
            // 
            // utilsSeparateLine1
            // 
            this.utilsSeparateLine1.BackColor = System.Drawing.Color.Transparent;
            this.utilsSeparateLine1.LineColor = System.Drawing.Color.Black;
            this.utilsSeparateLine1.Location = new System.Drawing.Point(0, 204);
            this.utilsSeparateLine1.Name = "utilsSeparateLine1";
            this.utilsSeparateLine1.Size = new System.Drawing.Size(888, 34);
            this.utilsSeparateLine1.TabIndex = 2;
            // 
            // utilsSeparateLine2
            // 
            this.utilsSeparateLine2.BackColor = System.Drawing.Color.Transparent;
            this.utilsSeparateLine2.LineColor = System.Drawing.Color.Black;
            this.utilsSeparateLine2.Location = new System.Drawing.Point(0, 300);
            this.utilsSeparateLine2.Name = "utilsSeparateLine2";
            this.utilsSeparateLine2.Size = new System.Drawing.Size(888, 34);
            this.utilsSeparateLine2.TabIndex = 3;
            // 
            // utilsFlatButton1
            // 
            this.utilsFlatButton1.Active = false;
            this.utilsFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.utilsFlatButton1.BorderRadius = 0;
            this.utilsFlatButton1.ButtonText = "Start";
            this.utilsFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.utilsFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.utilsFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.utilsFlatButton1.Iconimage = null;
            this.utilsFlatButton1.Iconimage_right = null;
            this.utilsFlatButton1.Iconimage_right_Selected = null;
            this.utilsFlatButton1.Iconimage_Selected = null;
            this.utilsFlatButton1.IconMarginLeft = 0;
            this.utilsFlatButton1.IconMarginRight = 0;
            this.utilsFlatButton1.IconRightVisible = true;
            this.utilsFlatButton1.IconRightZoom = 0D;
            this.utilsFlatButton1.IconVisible = true;
            this.utilsFlatButton1.IconZoom = 90D;
            this.utilsFlatButton1.IsTab = false;
            this.utilsFlatButton1.Location = new System.Drawing.Point(43, 256);
            this.utilsFlatButton1.Name = "utilsFlatButton1";
            this.utilsFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.utilsFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.utilsFlatButton1.selected = false;
            this.utilsFlatButton1.Size = new System.Drawing.Size(257, 48);
            this.utilsFlatButton1.TabIndex = 4;
            this.utilsFlatButton1.Text = "Start";
            this.utilsFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.utilsFlatButton1.Textcolor = System.Drawing.Color.White;
            this.utilsFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsFlatButton1.Click += new System.EventHandler(this.utilsFlatButton1_Click);
            // 
            // utilsFlatButton2
            // 
            this.utilsFlatButton2.Active = false;
            this.utilsFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.utilsFlatButton2.BorderRadius = 0;
            this.utilsFlatButton2.ButtonText = "Stop";
            this.utilsFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.utilsFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.utilsFlatButton2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.utilsFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.utilsFlatButton2.Iconimage = null;
            this.utilsFlatButton2.Iconimage_right = null;
            this.utilsFlatButton2.Iconimage_right_Selected = null;
            this.utilsFlatButton2.Iconimage_Selected = null;
            this.utilsFlatButton2.IconMarginLeft = 0;
            this.utilsFlatButton2.IconMarginRight = 0;
            this.utilsFlatButton2.IconRightVisible = true;
            this.utilsFlatButton2.IconRightZoom = 0D;
            this.utilsFlatButton2.IconVisible = true;
            this.utilsFlatButton2.IconZoom = 90D;
            this.utilsFlatButton2.IsTab = false;
            this.utilsFlatButton2.Location = new System.Drawing.Point(505, 256);
            this.utilsFlatButton2.Name = "utilsFlatButton2";
            this.utilsFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.utilsFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.utilsFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.utilsFlatButton2.selected = false;
            this.utilsFlatButton2.Size = new System.Drawing.Size(257, 48);
            this.utilsFlatButton2.TabIndex = 5;
            this.utilsFlatButton2.Text = "Stop";
            this.utilsFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.utilsFlatButton2.Textcolor = System.Drawing.Color.White;
            this.utilsFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsFlatButton2.Click += new System.EventHandler(this.utilsFlatButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // utilsLabel3
            // 
            this.utilsLabel3.AutoSize = true;
            this.utilsLabel3.Location = new System.Drawing.Point(12, 79);
            this.utilsLabel3.Name = "utilsLabel3";
            this.utilsLabel3.Size = new System.Drawing.Size(61, 13);
            this.utilsLabel3.TabIndex = 7;
            this.utilsLabel3.Text = "PIN Lenght";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 8;
            // 
            // utilsLabel4
            // 
            this.utilsLabel4.AutoSize = true;
            this.utilsLabel4.Location = new System.Drawing.Point(310, 75);
            this.utilsLabel4.Name = "utilsLabel4";
            this.utilsLabel4.Size = new System.Drawing.Size(72, 13);
            this.utilsLabel4.TabIndex = 9;
            this.utilsLabel4.Text = "Timeout in ms";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 340);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(864, 164);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // utilsLabel5
            // 
            this.utilsLabel5.AutoSize = true;
            this.utilsLabel5.Location = new System.Drawing.Point(540, 76);
            this.utilsLabel5.Name = "utilsLabel5";
            this.utilsLabel5.Size = new System.Drawing.Size(62, 13);
            this.utilsLabel5.TabIndex = 11;
            this.utilsLabel5.Text = "Correct PIN";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Security_Tester___Bruteforce.Properties.Resources.pictureBox2_Image;
            this.pictureBox1.Location = new System.Drawing.Point(832, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.utilsLabel5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.utilsLabel4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.utilsLabel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.utilsFlatButton2);
            this.Controls.Add(this.utilsFlatButton1);
            this.Controls.Add(this.utilsSeparateLine2);
            this.Controls.Add(this.utilsSeparateLine1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.Framework.UtilsDragControl utilsDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Utils.Framework.utilsLabel utilsLabel2;
        private Utils.Framework.utilsLabel utilsLabel1;
        private Utils.Framework.utilsSeparateLine utilsSeparateLine1;
        private Utils.Framework.utilsSeparateLine utilsSeparateLine2;
        private Utils.Framework.utilsFlatButton utilsFlatButton1;
        private Utils.Framework.utilsFlatButton utilsFlatButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Utils.Framework.utilsLabel utilsLabel3;
        private System.Windows.Forms.TextBox textBox2;
        private Utils.Framework.utilsLabel utilsLabel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Utils.Framework.utilsLabel utilsLabel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

