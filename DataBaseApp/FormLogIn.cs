using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{    
    public partial class FormLogIn : Form
    {
        int stepNumber = 1;
        string username = "root";
        string password = "1339";

        private static readonly Color darkRed = Color.FromArgb(224, 96, 85);
        private static readonly Color darkViolet = Color.FromArgb(81, 67, 143);
        private static readonly Color lightViolet = Color.FromArgb(111, 92, 195);
        private static readonly Color bgGrey = Color.FromArgb(237, 237, 237);
        private static readonly Color lightGrey = Color.FromArgb(224, 224, 224);

        public FormLogIn()
        {
            InitializeComponent();
        }
        
        private void buttonNextStep_Click(object sender, EventArgs e)
        {           
            if (stepNumber == 1)
            {                
                username = textBoxDataToEnter.Text;

                if ((!(username.Equals("root")) || (username.Equals("enter username"))))
                {
                    textBoxDataToEnter.Text = " try again";
                    textBoxDataToEnter.ForeColor = darkRed;
                    buttonNextStep.BackColor = Color.Silver;
                    this.ActiveControl = buttonNextStep;
                    buttonNextStep.Enabled = false;
                }
                else if (username.Equals("root"))
                {                   
                    textBoxDataToEnter.Text = "";
                    stepNumber = 2;
                    textBoxDataToEnter.Text = "enter password";
                    textBoxDataToEnter.ForeColor = lightGrey;
                    pictureBoxPassword.Visible = true;
                    this.ActiveControl = buttonNextStep;
                    buttonNextStep.Enabled = false;
                    buttonNextStep.BackColor = Color.Silver;
                }
            }
            else if (stepNumber == 2)
            {
                password = textBoxDataToEnter.Text;               
                showLoader();                
            }             
        }

        private async void showLoader()
        {       
            labelLog.Visible = false;
            panelDataToEnter.Visible = false;
            buttonNextStep.Visible = false;
            Loader.Visible = true;

            await Task.Delay(3000);
           
            labelLog.Visible = true;
            panelDataToEnter.Visible = true;
            buttonNextStep.Visible = true;
            Loader.Visible = false;

            if (password.Equals("1339"))
            {
                labelLog.Visible = false;
                pictureBoxPassword.Visible = false;
                pictureBoxUser.Visible = false;
                textBoxDataToEnter.Visible = false;
                panelDataToEnter.BackColor = bgGrey;

                stepNumber = 3;
                openDB();
            }
            else
            {
                textBoxDataToEnter.Text = "incorrect password try again";
                textBoxDataToEnter.ForeColor = darkRed;   
                textBoxDataToEnter.UseSystemPasswordChar = false;
                buttonNextStep.BackColor = Color.Silver;
                this.ActiveControl = buttonNextStep;
                buttonNextStep.Enabled = false;

                stepNumber = 2;
            }
        }

        private void openDB()
        {            
            new FormMain().Show(); 
            this.Hide();            //закрыть из мейна именно эту форму (без new) логина(this)
        }

        private void textBoxDataToEnter_Click(object sender, EventArgs e)
        {
            if (stepNumber == 1)
            {
                textBoxDataToEnter.Text = "";
                textBoxDataToEnter.ForeColor = darkViolet;
            }
            else if (stepNumber == 2)
            {
                textBoxDataToEnter.Text = "";
                textBoxDataToEnter.ForeColor = darkViolet;
                textBoxDataToEnter.UseSystemPasswordChar = true;
            }
        }

        private void textBoxDataToEnter_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }                       
        }

        private void textBoxDataToEnter_TextChanged(object sender, EventArgs e)
        {
            username = textBoxDataToEnter.Text;
            password = textBoxDataToEnter.Text;

            if (username.Length > 2 || password.Length > 2)
            {
                buttonNextStep.Enabled = true;
            }
            else if (username.Length <= 2 || password.Length <= 2)
            {
                buttonNextStep.Enabled = false;
                buttonNextStep.BackColor = Color.Silver;
            }
        }

        private void textBoxDataToEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonNextStep_Click((object)sender, (EventArgs)e);                
            }
        }


        private void buttonNextStep_MouseLeave(object sender, EventArgs e)
        {
            if (username.Length > 2 || password.Length > 2)
            {
                buttonNextStep.BackColor = Color.Silver;
            }
        }

        private void buttonNextStep_MouseEnter(object sender, EventArgs e)
        {
            if (username.Length > 2 || password.Length > 2)
            {
                buttonNextStep.BackColor = lightViolet;
            }
        }
    }    
}
