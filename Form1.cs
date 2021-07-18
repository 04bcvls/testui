using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double Fil = 0.0, Eng = 0.0, Math = 0.0, Sci = 0.0, Ap = 0.0, Comp = 0.0, Mapeh = 0.0, Valed = 0.0;

        double _sum, _aveRes;
        double _transRes;
        

        string _str, _str2;
        string[] mark = { "PASSED!", "FAILED!" };
        string[] honor = { "With HIGHEST HONORS", "With HIGH HONORS", "With HONORS", "NOT HONOR, SOME SUBJECTS DID NOT MEET THE PROFICIENCY LEVEL" };

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox0.AppendText("0");
            textBox1.AppendText("0");
            textBox2.AppendText("0");
            textBox3.AppendText("0");
            textBox4.AppendText("0");
            textBox5.AppendText("0");
            textBox6.AppendText("0");
            textBox7.AppendText("0");

            textBox0.SelectAll();

            richTextBox1.AppendText("AVERAGE GRADE WILL DISPLAY HERE");
            richTextBox2.AppendText("TRANSMUTED GRADE WILL DISPLAY HERE");
            richTextBox3.AppendText("REMARKS WILL DISPLAY HERE");

        }

        //DISABLE SPACE and LIMIT CHARACTER INPUT
        private void TextBoxAll_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar == ' ';
            textBox0.MaxLength = 7;
            textBox1.MaxLength = 7;
            textBox2.MaxLength = 7;
            textBox3.MaxLength = 7;
            textBox4.MaxLength = 7;
            textBox5.MaxLength = 7;
            textBox6.MaxLength = 7;
            textBox7.MaxLength = 7;

        }

        //
        //CALCULATE AND TRANSMUTE AVERAGE GRADE
        //
        private void button1_Click_1(object sender, EventArgs e)
        {

            //VALIDATING USER INPUT

            if (!double.TryParse(textBox0.Text, out Fil) || !double.TryParse(textBox1.Text, out Eng) || !double.TryParse(textBox2.Text, out Math) || !double.TryParse(textBox3.Text, out Sci) || !double.TryParse(textBox4.Text, out Ap) || !double.TryParse(textBox5.Text, out Comp) || !double.TryParse(textBox6.Text, out Mapeh) || !double.TryParse(textBox7.Text, out Valed))
            {
                MessageBoxButtons butt = MessageBoxButtons.OK;
                DialogResult diagres = MessageBox.Show("INVALID INPUT.\nPlease check the values thoroughly.", "ERROR", butt, MessageBoxIcon.Error);
            }
            else
            {

                //gathering input (Parsing)
                Fil = double.Parse(textBox0.Text);
                Eng = double.Parse(textBox1.Text);
                Math = double.Parse(textBox2.Text);
                Sci = double.Parse(textBox3.Text);
                Ap = double.Parse(textBox4.Text);
                Comp = double.Parse(textBox5.Text);
                Mapeh = double.Parse(textBox6.Text);
                Valed = double.Parse(textBox7.Text);

                //Filipino
                if (Fil >= 60)
                {
                    Fil = (int)(75 + ((Fil - 60) / 1.6));
                }
                else if (Fil < 60)
                {
                    Fil = (int)((60 + Fil / 4));
                }

                //English
                if (Eng >= 60)
                {
                    Eng = (int)(75 + ((Eng - 60) / 1.6));
                }
                else if (Eng< 60)
                {
                    Eng = (int)((60 + Eng / 4));
                }

                //Mathematics
                if (Math >= 60)
                {
                    Math = (int)(75 + ((Math - 60) / 1.6));
                }
                else if (Math < 60)
                {
                    Math = (int)((60 + Math / 4));
                }

                //Science
                if (Sci >= 60)
                {
                    Sci = (int)(75 + ((Sci - 60) / 1.6));
                }
                else if (Sci < 60)
                {
                    Sci = (int)((60 + Sci / 4));
                }

                //AP
                if (Ap >= 60)
                {
                    Ap = (int)(75 + ((Ap - 60) / 1.6));
                }
                else if (Ap < 60)
                {
                    Ap = (int)((60 + Ap / 4));
                }
                //Computer
                if (Comp >= 60)
                {
                    Comp = (int)(75 + ((Comp - 60) / 1.6));
                }
                else if (Comp < 60)
                {
                    Comp = (int)((60 + Comp / 4));
                }
                //MAPEH
                if (Mapeh >= 60)
                {
                    Mapeh = (int)(75 + ((Mapeh - 60) / 1.6));
                }
                else if (Mapeh < 60)
                {
                    Mapeh = (int)((60 + Mapeh / 4));
                }
                //Values Education
                if (Valed >= 60)
                {
                    Valed = (int)(75 + ((Valed - 60) / 1.6));
                }
                else if (Valed < 60)
                {
                    Valed = (int)((60 + Valed / 4));
                }

                //calculate average
                _sum = Fil + Eng + Math + Sci + Ap + Comp + Mapeh + Valed;
                _aveRes = _sum / 8;

                _str = _aveRes.ToString("n2");
                richTextBox1.Clear();   //clears the box
                richTextBox1.Font = new Font("Digital-7", 17, FontStyle.Bold);  //changes font for average grade (_str = _aveRes.Tostring())
                richTextBox1.AppendText(_str);  //displays the general average



                //TRANSMUTATION
                double shrt = ((_aveRes * 1.0) + 0.5);
                double fnl = (int)shrt / 1.0;
                _transRes = fnl;
                _str2 = _transRes.ToString();   //converts float to string for richTextBox2
                richTextBox2.Clear();   //clears the box
                richTextBox2.Font = new Font("Digital-7", 17, FontStyle.Bold);  //changes font for average grade (_str2 = _transRes.Tostring())
                richTextBox2.AppendText(_str2);  //displays the general average



                //REMARKS
                richTextBox3.Clear();

                //with highest honor
                if ((_transRes >= 98 && _transRes <= 100) && ((Fil >= 85 && Fil <= 100) && (Eng >= 85 && Eng <= 100) && (Sci >= 85 && Sci <= 100) && (Ap >= 85 && Ap <= 100) && (Comp >= 85 && Comp <= 100) && (Mapeh >= 85 && Mapeh <= 100) && (Valed >= 85 && Valed <= 100)))
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.DarkGreen;
                    richTextBox3.AppendText(mark[0]);
                    richTextBox3.AppendText("\n\n");
                    richTextBox3.AppendText(honor[0]);
                }
                //with high honor
                else if ((_transRes >= 95 && _transRes <= 97) && ((Fil >= 85 && Fil <= 100) && (Eng >= 85 && Eng <= 100) && (Sci >= 85 && Sci <= 100) && (Ap >= 85 && Ap <= 100) && (Comp >= 85 && Comp <= 100) && (Mapeh >= 85 && Mapeh <= 100) && (Valed >= 85 && Valed <= 100)))
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.Green;
                    richTextBox3.AppendText(mark[0]);
                    richTextBox3.AppendText("\n\n");
                    richTextBox3.AppendText(honor[1]);
                }
                //with honor
                else if ((_transRes >= 90 && _transRes <= 94) && ((Fil >= 85 && Fil <= 100) && (Eng >= 85 && Eng <= 100) && (Sci >= 85 && Sci <= 100) && (Ap >= 85 && Ap <= 100) && (Comp >= 85 && Comp <= 100) && (Mapeh >= 85 && Mapeh <= 100) && (Valed >= 85 && Valed <= 100)))
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.LimeGreen;
                    richTextBox3.AppendText(mark[0]);
                    richTextBox3.AppendText("\n\n");
                    richTextBox3.AppendText(honor[2]);
                }
                //passed only
                else if ((_transRes >= 75 && _transRes <= 100) && (Fil >= 75 && Fil <= 84 || Eng >= 75 && Eng <= 84 || Sci >= 75 && Sci <= 84 || Ap >= 75 && Ap <= 84 || Comp >= 75 && Comp <= 84 || Mapeh >= 75 && Mapeh <= 84 || Valed >= 75 && Valed <= 84))
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.Lime;
                    richTextBox3.AppendText(mark[0]);

                }

                //failed
                else if ((_aveRes >= 0.1 && _aveRes <= 100) && (_transRes >= 0.1 && _transRes <= 100) && ((Fil >= 0 && Fil < 60) || (Eng >= 0 && Eng < 60) || (Sci >= 0 && Sci < 60) || (Ap >= 0 && Ap < 60) || (Comp >= 0 && Comp < 60) || (Mapeh >= 0 && Mapeh < 60) || (Valed >= 0 && Valed < 60)))
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.Red;
                    richTextBox3.AppendText(mark[1]);
                }

                else
                {
                    richTextBox3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    richTextBox3.ForeColor = System.Drawing.Color.Black;
                    richTextBox3.AppendText("INVALID INPUT!");
                }

            }

        }


        //RESET BUTTON
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();

            textBox0.AppendText("0");
            textBox1.AppendText("0");
            textBox2.AppendText("0");
            textBox3.AppendText("0");
            textBox4.AppendText("0");
            textBox5.AppendText("0");
            textBox6.AppendText("0");
            textBox7.AppendText("0");

            richTextBox1.SelectAll();
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            richTextBox1.AppendText("AVERAGE GRADE WILL DISPLAY HERE");

            richTextBox2.SelectAll();
            this.richTextBox2.Font = new System.Drawing.Font("Montserrat Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox2.AppendText("TRANSMUTED GRADE WILL DISPLAY HERE");

            richTextBox3.SelectAll();
            this.richTextBox3.Font = new System.Drawing.Font("Montserrat Light", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.Black;
            richTextBox3.AppendText("REMARKS WILL DISPLAY HERE");
        }

        //ABOUT BOX
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "GRADE CALCULATOR\n" +
                         "beta 0.5.0\n" +
                         "© 2021 bibo. All rights reserved.\n" +
                         "This program is intended only for educational purposes.\n" +
                         "Not for commercial use.\n\n" +
                         "NOTE:\n" +
                         "GRADE CALCULATOR is a helpful application for students\n" +
                         "and teachers in solving Final Grade without the need of\n" +
                         "Transmutation Table.\n" +
                         "To use GRADE CALCULATOR, You must have:\n" +
                         "• INITIAL grade of every subject*\n" +
                         "*grades of each subject must not be transmuted as it \n" +
                         "will automatically transmute within the program.";
            MessageBoxButtons butt = MessageBoxButtons.OK;
            DialogResult diagres = MessageBox.Show(msg, "About", butt, MessageBoxIcon.Information);
        }

        //ENTER KEY PRESSED SHORTCUT
        private void TextBoxAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.BackColor = System.Drawing.Color.Navy;

                button1_Click_1(sender, new KeyEventArgs(Keys.Enter));
                e.SuppressKeyPress = true;
            }
        }
        private void TextBoxAll_KeyUp(object sender, KeyEventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
        }

        //HIGHLIGHT TEXT WHEN TABBING/ENTERING
        private void textBox0_Enter(object sender, EventArgs e)
        {
            textBox0.SelectAll();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.SelectAll();
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.SelectAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
