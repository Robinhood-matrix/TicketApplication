using System;
using System.Windows.Forms;

namespace ticketSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
           


        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string un = usrNameTxtBox.Text;
            string pw = pwdTxtBox.Text;
            if (usrNameTxtBox.Text != string.Empty || pwdTxtBox.Text != string.Empty)//runs code if the user and password text box is not empty. 
            {

                if (un == GlobalValues.UserName)//checking wether username and password is incorrect 
                {
                    if (pw == GlobalValues.Password)
                    {
                        GlobalValues.IsAdmin = true;
                        AdminPanel form1 = new AdminPanel();
                        this.Hide();
                        form1.Show();

                    }
                    else
                    {

                    }
                    {
                        warningLabel.Text = "Invalid password.";
                        warningLabel.Visible = true;

                    }
                }
                else
                {
                    warningLabel.Text = "Invalid uaername.";
                    warningLabel.Visible = true;

                }
            }
            else
            {
                warningLabel.Text = "Username and Password Required";
                warningLabel.Visible = true;

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            GlobalValues.IsAdmin = false;
            UserPanel form1 = new UserPanel();
            this.Hide();
            form1.Show();

        }

        private void ShowPwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
         
           if (ShowPwdCheckBox.Checked == true)
           {
               pwdTxtBox.UseSystemPasswordChar = false;
           }
           else
           {
               pwdTxtBox.UseSystemPasswordChar = true;
           }
          
        }
    }
}
