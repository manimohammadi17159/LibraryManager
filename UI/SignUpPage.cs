using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class SignUpPage : Form
    {

        ISignUp _signUp;
        public SignUpPage(ISignUp signUp)
        {
            _signUp = signUp;
            InitializeComponent();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();


            namelbl.Visible = CheckTextBox(txtbx_Name);
            lastnamelbl.Visible = CheckTextBox(txtbx_Lastname);
            passwordlbl.Visible = CheckTextBox(txtbx_Password);

            bool check = _signUp.CheckBeUniqe(txtbx_Username.Text);
            usernamelbl.Visible = check == true ? false : true;

            if (usernamelbl.Visible == false && passwordlbl.Visible == false && namelbl.Visible == false && lastnamelbl.Visible == false)
            {
                newUser.Name = txtbx_Name.Text;
                newUser.Lastname = txtbx_Lastname.Text;
                newUser.Username = txtbx_Username.Text;
                newUser.Password = txtbx_Password.Text;

                _signUp.Start(newUser);

                this.Open("login");
            }


        }
        private static bool CheckTextBox(TextBox textBox)
        {
            if (textBox.Text.Length < 3 || textBox.Text.Length > 10)
            {
                return true;//need show error
            }

            else return false;// input was true
        }
    }
}
