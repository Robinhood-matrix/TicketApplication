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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string un = usrNameTxtBox.Text;
            string pw = pwdTxtBox.Text;
            if (usrNameTxtBox.Text != string.Empty || pwdTxtBox.Text != string.Empty)
            {

                if (un == GlobalValues.UserName)
                {
                    if (pw == GlobalValues.Password)
                    {
                        GlobalValues.IsAdmin = true;
                        MainForm form1 = new MainForm();
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

        private void showPwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwdCheckBox.Checked == true)
            {
                pwdTxtBox.UseSystemPasswordChar = false;
            }
            else
            {
                pwdTxtBox.UseSystemPasswordChar = true;
            }
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            GlobalValues.IsAdmin = false;
            MainForm form1 = new MainForm();
            this.Hide();
            form1.Show();

        }
    }
}
