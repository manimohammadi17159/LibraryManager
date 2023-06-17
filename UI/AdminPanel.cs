using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class AdminPanel : Form
    {
        IUserManager _userManager;
        IBookIndex _bookIndex;
        User _user = new();
        public AdminPanel(IUserManager userManager, IBookIndex bookIndex)
        {
            _bookIndex = bookIndex;
            _userManager = userManager;
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //Show all of the user inn listview
            var users = _userManager.GetUsers();

            foreach (var user in users)
            {
                string[] row = new string[3];

                row[0] = user.Username;
                row[1] = user.Name;
                row[2] = user.Lastname;

                lvUsers.Items.Add(new ListViewItem(row));
            }
            lblTotal.Text = _bookIndex.GetTotalSales().ToString();
            lblUsers.Text = _userManager.GetUsersCount().ToString();
            lblTotalBookSold.Text = _bookIndex.GetTotalBookSold().ToString();
            lblBookCount.Text = _bookIndex.GetBookCount().ToString();
               
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            var user = _userManager.FindUser(lv.FocusedItem.SubItems[0].Text);
            _user = user;

            lblName.Text = user.Name;
            lblLatsname.Text = user.Lastname;
            lblUsername.Text = user.Username;
            lblPassword.Text = user.Password;
            lblCredit.Text = user.Credit.ToString();

            lblCredit.Visible = true;
            lblLatsname.Visible = true;
            lblName.Visible = true;
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text != string.Empty && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty && txtName.Text != string.Empty
                && txtCredit.Text != string.Empty) MessageBox.Show("Textbox can not be empty");

            else
            {
                
                if (txtName.Text != string.Empty) _user.Name = txtName.Text;
                if (txtLastname.Text != string.Empty) _user.Lastname = txtLastname.Text;
                if (txtUsername.Text != string.Empty) _user.Username = txtUsername.Text;
                if (txtPassword.Text != string.Empty) _user.Password = txtPassword.Text;
                if (txtCredit.Text != string.Empty) _user.Credit = Convert.ToDecimal(txtCredit.Text);

                _userManager.NewInfo(_user);

                MessageBox.Show("Information has been edited");

                this.Open("admin panel");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _userManager.DeleteUser(_user.Id);
            MessageBox.Show("Username deleted");

            this.Open("admin panel");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Open("insert book");
        }
    }
}
