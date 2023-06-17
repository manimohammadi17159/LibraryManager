using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class BookInfo : Form
    {
        decimal _credit;

        User _user = new();
        Book _book = new();

        IUserBookManager _userBookManager;
        ICreditUpdater _creditUpdater;
        public BookInfo(ICreditUpdater creditUpdater, IUserBookManager userBookManager)
        {
            _creditUpdater = creditUpdater;

            _userBookManager = userBookManager;

            InitializeComponent();          
        }
        public void SetInfo(Book book, Image image, User user)
        {
            this.lblBookName.Text = book.Name;
            this.lblTranslator.Text = book.Translator;
            this.lblWriter.Text = book.Writer;
            this.lblPrice.Text = book.Price.ToString();
            this.pbCover.Image = image;
            _book.ImageAddress = book.ImageAddress;
            _book.Name = book.Name;
            _user = user;
            _credit = user.Credit;

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(lblPrice.Text);
            lblNotEnough.Visible = _credit > price ? false : true;

            if (lblNotEnough.Visible == false)
            {
                _user.Credit = _creditUpdater.CreditDeductor(_user.Username, price);

                _userBookManager.NewUserBook(_user.Username, _book);
                
                MessageBox.Show("Your purchase was successful");

                this.Open("book shop", _user);
            }

           
        }
        private void BookInfo_Load(object sender, EventArgs e)
        {
            bool check = _userBookManager.FindUserBook(_user.Username, _book.Name);

            btnBuy.Visible = check == true ? false : true;
            lblAlreadyBuy.Visible = check == true ? true : false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackToMain();
        }
    }
}
