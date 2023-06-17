using Domain.Interface;
using Domain.Model;
using Microsoft.VisualBasic.ApplicationServices;
using UI.ExtenstionMethod;


using Domain.Model;


namespace UI
{
    public partial class BookShop : Form
    {

        IBookManager _bookManager;
        IUserBookManager _userBookManager;
        ICreditUpdater _creditUpdater;
        Domain.Model.User _user;
        

        public BookShop(IBookManager bookManager, ICreditUpdater creditUpdater , IUserBookManager userBookManager, Domain.Model.User user)
        {
            _bookManager = bookManager;
            _creditUpdater = creditUpdater;
            _userBookManager = userBookManager;
            _user = user;
            InitializeComponent();

            Creditlbl.Text = user.Credit.ToString();
        }

        private void BookShop_Load(object sender, EventArgs e)
        {

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
