using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            this.BackColor = Color.FromArgb(43, 43, 43);
            panelHeader.BackColor = Color.FromArgb(47, 47, 50);
            buttonGenerate.BackColor = Color.FromArgb(43, 43, 43);
            buttonReset.BackColor = Color.FromArgb(43, 43, 43);
            buttonCopy.BackColor = Color.FromArgb(43, 43, 43);

        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(43, 43, 43); 
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void buttonMinimize_DragLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void buttonMinNormal_MouseEnter(object sender, EventArgs e)
        {
            buttonMinNormal.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void buttonMinNormal_DragLeave(object sender, EventArgs e)
        {
            buttonMinNormal.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void buttonMinNormal_Click(object sender, EventArgs e)
        {

            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;

            }



        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

     
        private void buttonGenerate_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonGenerate_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonReset_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonReset_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonCopy_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonCopy_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelPasswordLength.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        private int GenerateRandomNumberInRange(int From, int to)
        {
            Random random = new Random();

            return random.Next(From, to);

        }
        private bool NonChecked()
        {

          return (CapitalLetter.Checked == false && SmallLetter.Checked == false && Numbers.Checked == false &&
                Symbols.Checked == false) ;
               


        }

        int Random = 0;
        string Password = "";
        enum EnChoices
        {
            Small   =0,
            Capital =1,
            Numbers =2,
            Symbols =3,
           
        }

        List<EnChoices> CheckList = new List<EnChoices>();
        private void CheckedChanged(object sender, EventArgs e) 
        {
            CheckList.Clear();
            if (SmallLetter.Checked)
            {
                CheckList.Add(EnChoices.Small);
            }


            if (Numbers.Checked)
            {
                CheckList.Add(EnChoices.Numbers);
            }


            if (CapitalLetter.Checked)
            {
                CheckList.Add(EnChoices.Capital);
            }

            if (Symbols.Checked)
            {
                CheckList.Add(EnChoices.Symbols);
            }



        }

        private char GenerateRandomCharacter(int Index)
        {
            return (char)Index;
        }


        private char  ReturnCharacter()
        {
            Thread.Sleep(1);
            Random = (GenerateRandomNumberInRange(1, CheckList.Count() + 1));
            Char Value = ' ';

          
            if ((EnChoices)CheckList[Random-1] == EnChoices.Small)
            {
                Value = GenerateRandomCharacter(GenerateRandomNumberInRange(97,122));
                return Value;
            }

            if ((EnChoices)CheckList[Random - 1] == EnChoices.Capital)
            {
                Value = GenerateRandomCharacter(GenerateRandomNumberInRange(65, 90));
                return Value;
            }

            if ((EnChoices)CheckList[Random - 1] == EnChoices.Symbols)
            {
                Value = GenerateRandomCharacter(GenerateRandomNumberInRange(33, 47));
                return Value;
            }

            if ((EnChoices)CheckList[Random - 1] == EnChoices.Numbers)
            {
                Value = GenerateRandomCharacter(GenerateRandomNumberInRange(48, 57));
                return Value;
                
            }

            return Value;

           
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (NonChecked())
                return;

            string TempPassword = "";
            for (int i = 0; i < trackBar1.Value; i++)
            {

                TempPassword+=(ReturnCharacter());

            }
            
            this.Refresh();
            Password = TempPassword;

            textBox1.Text = Password;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Password = "";
            textBox1.Clear();

            SmallLetter.Checked = false;
            CapitalLetter.Checked = false;
            Symbols.Checked = false;
            Numbers.Checked = false;
            trackBar1.Value = 1;
            buttonCopy.Enabled = false;
            labelPasswordLength.Text = "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                buttonCopy.Enabled = true;
            }
            if (textBox1.Text == null)
            {
                buttonCopy.Enabled = false;
            }


        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Password : " + textBox1.Text + Environment.NewLine + "Copied To ClipBoard","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
