using Domain.Interface;
using Domain.Model;
using Microsoft.VisualBasic.ApplicationServices;
using UI.ExtenstionMethod;



namespace UI
{
    public partial class BookShop : Form
    {

        IBookManager _bookManager;
        IUserBookManager _userBookManager;
        ICreditUpdater _creditUpdater;
        Domain.Model.User _user;
        

        public BookShop(IBookManager bookManager, ICreditUpdater creditUpdater , IUserBookManager userBookManager)
        {
            _bookManager = bookManager;
            _creditUpdater = creditUpdater;
            _userBookManager = userBookManager;
            InitializeComponent();
        }
        public void SetUserInfo(Domain.Model.User user)
            =>_user = user;

        private void BookShop_Load(object sender, EventArgs e)
        {
            Creditlbl.Text = _user.Credit.ToString();

            pictureBoxes = _bookManager.GetAllBooks().ConvertToPictureBoxShop(30, 30);

            this.panel1.ShowInPanel(pictureBoxes);

            foreach (PictureBox pb in panel1.Controls.OfType<PictureBox>())
            {
                pb.Click += PictureBox_Click;
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;

            Book book = new();

            book.Name = pictureBox.Name;

            book = _bookManager.SearchBook(book.Name);

            BookInfo bookInfoForm = new(_creditUpdater, _userBookManager);

            decimal credit = Convert.ToDecimal(Creditlbl.Text);
            bookInfoForm.SetInfo(book, pictureBox.Image, _user);

            this.Visible = false;
            bookInfoForm.Visible = true;

        }

        private void LlblCharg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Open("charge credit", _user);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Open("profile", _user);
        }
    }
}
