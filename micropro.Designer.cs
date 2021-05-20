namespace Fortune_Infotech
{
    partial class micropro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(micropro));
            this.label1 = new System.Windows.Forms.Label();
            this.rchmp1 = new System.Windows.Forms.RichTextBox();
            this.rchmp2 = new System.Windows.Forms.RichTextBox();
            this.rchmp3 = new System.Windows.Forms.RichTextBox();
            this.rchmp4 = new System.Windows.Forms.RichTextBox();
            this.rchmp5 = new System.Windows.Forms.RichTextBox();
            this.rchmp6 = new System.Windows.Forms.RichTextBox();
            this.rchmp7 = new System.Windows.Forms.RichTextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.rchmp8 = new System.Windows.Forms.RichTextBox();
            this.rchmp_con = new System.Windows.Forms.RichTextBox();
            this.rchmp11 = new System.Windows.Forms.RichTextBox();
            this.rchmp10 = new System.Windows.Forms.RichTextBox();
            this.rchmp9 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Micro Processor (8085) Lab";
            // 
            // rchmp1
            // 
            this.rchmp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp1.Location = new System.Drawing.Point(80, 71);
            this.rchmp1.Name = "rchmp1";
            this.rchmp1.ReadOnly = true;
            this.rchmp1.Size = new System.Drawing.Size(940, 442);
            this.rchmp1.TabIndex = 22;
            this.rchmp1.Text = "; 1. Program to find addition of two 8-bit numbers\n\nlxi h,2000h\nmov a,m\ninx h\nadd" +
    " m\ninx h\nmov m,a\ninx h\nmvi h,00\njnc over\ninr m\nover: hlt\n";
            this.rchmp1.Visible = false;
            // 
            // rchmp2
            // 
            this.rchmp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp2.Location = new System.Drawing.Point(80, 71);
            this.rchmp2.Name = "rchmp2";
            this.rchmp2.ReadOnly = true;
            this.rchmp2.Size = new System.Drawing.Size(940, 442);
            this.rchmp2.TabIndex = 23;
            this.rchmp2.Text = "; 2. Program to find subtraction of two 8-bit numbers\n\nlxi h,2000h\nmov a,m\ninx h\n" +
    "sub m\ninx h\nmov m,a\ninx h\nmvi h,00\njnc over\ninr m\nover: hlt\n";
            this.rchmp2.Visible = false;
            // 
            // rchmp3
            // 
            this.rchmp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp3.Location = new System.Drawing.Point(80, 71);
            this.rchmp3.Name = "rchmp3";
            this.rchmp3.ReadOnly = true;
            this.rchmp3.Size = new System.Drawing.Size(940, 442);
            this.rchmp3.TabIndex = 24;
            this.rchmp3.Text = "; 3. Program to find addition of two 16-bit numbers\n\nlxi h,8888h\nlxi b,1111h\ndad " +
    "b\nhlt\n";
            this.rchmp3.Visible = false;
            // 
            // rchmp4
            // 
            this.rchmp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp4.Location = new System.Drawing.Point(80, 71);
            this.rchmp4.Name = "rchmp4";
            this.rchmp4.ReadOnly = true;
            this.rchmp4.Size = new System.Drawing.Size(940, 442);
            this.rchmp4.TabIndex = 25;
            this.rchmp4.Text = "; 4. Programs to find subtraction of two 16-bit numbers\n\nlxi h,6666h\nlxi b,1111h\n" +
    "mov a,l\nsub c\nmov l,a\nmov h,a\nsbb b\nmov h,a\nhlt\n";
            this.rchmp4.Visible = false;
            // 
            // rchmp5
            // 
            this.rchmp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp5.Location = new System.Drawing.Point(80, 71);
            this.rchmp5.Name = "rchmp5";
            this.rchmp5.ReadOnly = true;
            this.rchmp5.Size = new System.Drawing.Size(940, 442);
            this.rchmp5.TabIndex = 26;
            this.rchmp5.Text = "; 5.Program to find addition of two 8-bit BCD numbers\n\nmvi a,86h\nmvi b,32h\nadd b\n" +
    "daa\nmov l,a\nmvi h,00\njnc over\ninr h\nover: hlt";
            this.rchmp5.Visible = false;
            // 
            // rchmp6
            // 
            this.rchmp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp6.Location = new System.Drawing.Point(80, 71);
            this.rchmp6.Name = "rchmp6";
            this.rchmp6.ReadOnly = true;
            this.rchmp6.Size = new System.Drawing.Size(940, 442);
            this.rchmp6.TabIndex = 27;
            this.rchmp6.Text = "; 6. Program to find subtraction of two 8-bit BCD numbers\n\nmvi c,85h\nmvi b,59h\nmv" +
    "i a,99h\nsub b\nadi 01\nadd c\ndaa \nsta 3005h\nhlt\n";
            this.rchmp6.Visible = false;
            // 
            // rchmp7
            // 
            this.rchmp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp7.Location = new System.Drawing.Point(80, 71);
            this.rchmp7.Name = "rchmp7";
            this.rchmp7.ReadOnly = true;
            this.rchmp7.Size = new System.Drawing.Size(940, 442);
            this.rchmp7.TabIndex = 28;
            this.rchmp7.Text = "; 7. Program to find multiplication of two 8-bit numbers using successive additio" +
    "n method.\n\nmvi b,09h\nmvi c,05h\nxra a\nrpt: add b\ndcr c\njnz rpt\nsta 2000h\nhlt\n";
            this.rchmp7.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(919, 538);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(101, 35);
            this.btnprint.TabIndex = 47;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // rchmp8
            // 
            this.rchmp8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp8.Location = new System.Drawing.Point(80, 71);
            this.rchmp8.Name = "rchmp8";
            this.rchmp8.ReadOnly = true;
            this.rchmp8.Size = new System.Drawing.Size(940, 442);
            this.rchmp8.TabIndex = 49;
            this.rchmp8.Text = resources.GetString("rchmp8.Text");
            this.rchmp8.Visible = false;
            // 
            // rchmp_con
            // 
            this.rchmp_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp_con.Location = new System.Drawing.Point(80, 71);
            this.rchmp_con.Name = "rchmp_con";
            this.rchmp_con.ReadOnly = true;
            this.rchmp_con.Size = new System.Drawing.Size(940, 442);
            this.rchmp_con.TabIndex = 53;
            this.rchmp_con.Text = resources.GetString("rchmp_con.Text");
            this.rchmp_con.Visible = false;
            // 
            // rchmp11
            // 
            this.rchmp11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp11.Location = new System.Drawing.Point(80, 71);
            this.rchmp11.Name = "rchmp11";
            this.rchmp11.ReadOnly = true;
            this.rchmp11.Size = new System.Drawing.Size(940, 442);
            this.rchmp11.TabIndex = 52;
            this.rchmp11.Text = resources.GetString("rchmp11.Text");
            this.rchmp11.Visible = false;
            // 
            // rchmp10
            // 
            this.rchmp10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp10.Location = new System.Drawing.Point(80, 71);
            this.rchmp10.Name = "rchmp10";
            this.rchmp10.ReadOnly = true;
            this.rchmp10.Size = new System.Drawing.Size(940, 442);
            this.rchmp10.TabIndex = 51;
            this.rchmp10.Text = "; 10. Program to swap two numbers\n\nmvi a,42h\nmov c,a\nmvi a,19h\nmov b,a\n;swap\nmov " +
    "a,c\nmov c,b\nmov b,a\nhlt\n";
            this.rchmp10.Visible = false;
            // 
            // rchmp9
            // 
            this.rchmp9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchmp9.Location = new System.Drawing.Point(80, 71);
            this.rchmp9.Name = "rchmp9";
            this.rchmp9.ReadOnly = true;
            this.rchmp9.Size = new System.Drawing.Size(940, 442);
            this.rchmp9.TabIndex = 50;
            this.rchmp9.Text = "; 9. Program to convert two BCD numbers to their HEX equivalent\n\nmvi b,15h\nmov a," +
    "b\nani 0fh\nmov c,a\nmov a,b\nani 0f0h\nrrc\nrrc\nrrc\nrrc\nmov d,a\nmvi e,0ah\nxra a\nagain" +
    ": add d\ndcr e\njnz again\nadd c\nhlt\n";
            this.rchmp9.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fortune_Infotech.Properties.Resources.printer;
            this.pictureBox1.Location = new System.Drawing.Point(867, 538);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // micropro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 585);
            this.Controls.Add(this.rchmp_con);
            this.Controls.Add(this.rchmp11);
            this.Controls.Add(this.rchmp10);
            this.Controls.Add(this.rchmp9);
            this.Controls.Add(this.rchmp8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.rchmp7);
            this.Controls.Add(this.rchmp6);
            this.Controls.Add(this.rchmp5);
            this.Controls.Add(this.rchmp4);
            this.Controls.Add(this.rchmp3);
            this.Controls.Add(this.rchmp2);
            this.Controls.Add(this.rchmp1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(260, 112);
            this.Name = "micropro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "micropro";
            this.Load += new System.EventHandler(this.micropro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchmp1;
        private System.Windows.Forms.RichTextBox rchmp2;
        private System.Windows.Forms.RichTextBox rchmp3;
        private System.Windows.Forms.RichTextBox rchmp4;
        private System.Windows.Forms.RichTextBox rchmp5;
        private System.Windows.Forms.RichTextBox rchmp6;
        private System.Windows.Forms.RichTextBox rchmp7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.RichTextBox rchmp8;
        private System.Windows.Forms.RichTextBox rchmp_con;
        private System.Windows.Forms.RichTextBox rchmp11;
        private System.Windows.Forms.RichTextBox rchmp10;
        private System.Windows.Forms.RichTextBox rchmp9;
    }
}