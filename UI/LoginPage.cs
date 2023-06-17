using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class LoginPage : Form
    {
        ILogin _login;
        public LoginPage(ILogin login)
        {
            _login = login;
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Open("sign up");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new();
            bool checkAdmin = false;

            if (lblUserModel.Text == "user")
            {
                user = _login.StartAsUser(txtbx_username.Text, txtbx_password.Text);
                lblnotfound.Visible = user != null ? false : true;

                if(lblnotfound.Visible == false) this.Open("book shop", user);
            }
            else if (lblUserModel.Text == "admin")
            {
                checkAdmin = _login.StartAsAdmin(txtbx_username.Text, txtbx_password.Text);
                lblnotfound.Visible = checkAdmin == true ? false : true;

                if (checkAdmin == true) this.Open("admin panel");
            }

        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            lblUserModel.Text = "admin";
            btnAdmin.BackColor = Color.Gray;
            btnUser.BackColor = Color.White;

            llblSignup.Visible = false;

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lblUserModel.Text = "user";

            btnUser.BackColor = Color.Gray;
            btnAdmin.BackColor = Color.White;

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
