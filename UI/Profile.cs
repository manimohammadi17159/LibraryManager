using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class Profile : Form
    {
        IUserBookRequest _bookRequest;
        User _user = new();
        public Profile(IUserBookRequest userBookRequest)
        {
            _bookRequest = userBookRequest;
            InitializeComponent();
        }

        public void SetUserInfo(User user)
          => _user = user;


        private void Profile_Load(object sender, EventArgs e)
        {
            lblName.Text = _user.Name;
            lblCredit.Text = _user.Credit.ToString();

            pictureBoxes = _bookRequest.SelectUserBooks(_user.Username).ConvertToPictureBoxProfile(30,30);
            panel1.ShowInPanel(pictureBoxes);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Open("book shop", _user);
        }
    }
}
