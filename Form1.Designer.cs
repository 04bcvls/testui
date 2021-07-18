namespace testui
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
            this.labelTit1 = new System.Windows.Forms.Label();
            this.iconLeft = new System.Windows.Forms.Label();
            this.iconRight = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.labelSub5 = new System.Windows.Forms.Label();
            this.labelSub3 = new System.Windows.Forms.Label();
            this.labelSub6 = new System.Windows.Forms.Label();
            this.labelSub4 = new System.Windows.Forms.Label();
            this.labelSub7 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.labelSub8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTit1
            // 
            this.labelTit1.BackColor = System.Drawing.Color.LightCyan;
            this.labelTit1.Font = new System.Drawing.Font("Font", 18F, System.Drawing.FontStyle.Bold);
            this.labelTit1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTit1.Location = new System.Drawing.Point(0, 6);
            this.labelTit1.Name = "labelTit1";
            this.labelTit1.Size = new System.Drawing.Size(445, 51);
            this.labelTit1.TabIndex = 10;
            this.labelTit1.Text = "GRADE CALCULATOR";
            this.labelTit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconLeft
            // 
            this.iconLeft.BackColor = System.Drawing.Color.Transparent;
            this.iconLeft.ForeColor = System.Drawing.Color.Transparent;
            this.iconLeft.Image = ((System.Drawing.Image)(resources.GetObject("iconLeft.Image")));
            this.iconLeft.Location = new System.Drawing.Point(12, 9);
            this.iconLeft.Name = "iconLeft";
            this.iconLeft.Size = new System.Drawing.Size(46, 48);
            this.iconLeft.TabIndex = 10;
            // 
            // iconRight
            // 
            this.iconRight.BackColor = System.Drawing.Color.Transparent;
            this.iconRight.ForeColor = System.Drawing.Color.Transparent;
            this.iconRight.Image = ((System.Drawing.Image)(resources.GetObject("iconRight.Image")));
            this.iconRight.Location = new System.Drawing.Point(379, 6);
            this.iconRight.Name = "iconRight";
            this.iconRight.Size = new System.Drawing.Size(51, 48);
            this.iconRight.TabIndex = 10;
            // 
            // labelGrade
            // 
            this.labelGrade.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.ForeColor = System.Drawing.Color.Black;
            this.labelGrade.Location = new System.Drawing.Point(0, 9);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(293, 33);
            this.labelGrade.TabIndex = 1;
            this.labelGrade.Text = "Put your INITIAL grade in:";
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGrade.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(316, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVERAGE FINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(316, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRANSMUTED FINAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(316, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "REMARKS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSub1
            // 
            this.labelSub1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub1.Location = new System.Drawing.Point(13, 43);
            this.labelSub1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(127, 14);
            this.labelSub1.TabIndex = 1;
            this.labelSub1.Text = "Filipino";
            this.labelSub1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub2
            // 
            this.labelSub2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub2.Location = new System.Drawing.Point(13, 113);
            this.labelSub2.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(127, 19);
            this.labelSub2.TabIndex = 1;
            this.labelSub2.Text = "English";
            this.labelSub2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub2.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub5
            // 
            this.labelSub5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub5.Location = new System.Drawing.Point(155, 43);
            this.labelSub5.Name = "labelSub5";
            this.labelSub5.Size = new System.Drawing.Size(127, 14);
            this.labelSub5.TabIndex = 1;
            this.labelSub5.Text = "AP";
            this.labelSub5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub5.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub3
            // 
            this.labelSub3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub3.Location = new System.Drawing.Point(13, 182);
            this.labelSub3.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.labelSub3.Name = "labelSub3";
            this.labelSub3.Size = new System.Drawing.Size(127, 14);
            this.labelSub3.TabIndex = 1;
            this.labelSub3.Text = "Mathematics";
            this.labelSub3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub3.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub6
            // 
            this.labelSub6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub6.Location = new System.Drawing.Point(155, 113);
            this.labelSub6.Name = "labelSub6";
            this.labelSub6.Size = new System.Drawing.Size(127, 19);
            this.labelSub6.TabIndex = 1;
            this.labelSub6.Text = "TLE";
            this.labelSub6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub6.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub4
            // 
            this.labelSub4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub4.Location = new System.Drawing.Point(13, 251);
            this.labelSub4.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.labelSub4.Name = "labelSub4";
            this.labelSub4.Size = new System.Drawing.Size(127, 14);
            this.labelSub4.TabIndex = 1;
            this.labelSub4.Text = "Science";
            this.labelSub4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub4.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub7
            // 
            this.labelSub7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub7.Location = new System.Drawing.Point(155, 182);
            this.labelSub7.Name = "labelSub7";
            this.labelSub7.Size = new System.Drawing.Size(127, 14);
            this.labelSub7.TabIndex = 1;
            this.labelSub7.Text = "MAPEH";
            this.labelSub7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(13, 62);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(127, 24);
            this.textBox0.TabIndex = 2;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox0.Enter += new System.EventHandler(this.textBox0_Enter);
            this.textBox0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // labelSub8
            // 
            this.labelSub8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub8.Location = new System.Drawing.Point(155, 251);
            this.labelSub8.Name = "labelSub8";
            this.labelSub8.Size = new System.Drawing.Size(127, 14);
            this.labelSub8.TabIndex = 1;
            this.labelSub8.Text = "Values Education/EsP";
            this.labelSub8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSub8.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 24);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 24);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 24);
            this.textBox5.TabIndex = 7;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 24);
            this.textBox6.TabIndex = 8;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(155, 268);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 24);
            this.textBox7.TabIndex = 9;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAll_KeyPress);
            this.textBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(316, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(114, 32);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Font = new System.Drawing.Font("Montserrat Light", 6F);
            this.richTextBox2.Location = new System.Drawing.Point(316, 151);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(114, 32);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox3.Font = new System.Drawing.Font("Montserrat Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(316, 210);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(114, 138);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.TabStop = false;
            this.richTextBox3.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelSub8);
            this.groupBox1.Controls.Add(this.textBox0);
            this.groupBox1.Controls.Add(this.labelSub7);
            this.groupBox1.Controls.Add(this.labelSub4);
            this.groupBox1.Controls.Add(this.labelSub6);
            this.groupBox1.Controls.Add(this.labelSub3);
            this.groupBox1.Controls.Add(this.labelSub5);
            this.groupBox1.Controls.Add(this.labelSub2);
            this.groupBox1.Controls.Add(this.labelSub1);
            this.groupBox1.Controls.Add(this.labelGrade);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(293, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(28, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "CALCULATE AND TRANSMUTE GRADES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(336, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(388, 397);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "0.6.0 beta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 413);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconRight);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.iconLeft);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelTit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GRADE CALCULATOR (0.6.0 beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAll_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTit1;
        private System.Windows.Forms.Label iconLeft;
        private System.Windows.Forms.Label iconRight;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.Label labelSub5;
        private System.Windows.Forms.Label labelSub3;
        private System.Windows.Forms.Label labelSub6;
        private System.Windows.Forms.Label labelSub4;
        private System.Windows.Forms.Label labelSub7;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label labelSub8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

