using Domain.Interface;
using Domain.Model;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class InsertNewBook : Form
    {

        IBookManager _bookManager;
        private string imageName;
        public InsertNewBook(IBookManager bookManager)
        {
            _bookManager = bookManager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Visible = txtName.CheckInfo();
            lblTranslator.Visible = txtTranslator.CheckInfo();
            lblWriter.Visible = txtWriter.CheckInfo();
            lblBookCover.Visible = pbBookCover.Image == null ? true : false;


            if (lblName.Visible == false && lblBookCover.Visible == false && lblTranslator.Visible == false && lblWriter.Visible == false)
            {
                Book newBook = new();
                newBook.Name = txtName.Text;
                newBook.Translator = txtTranslator.Text;
                newBook.Writer = txtWriter.Text;
                newBook.ImageAddress = imageName;
                newBook.Price = Convert.ToDecimal(txtPrice.Text);

                _bookManager.NewBook(newBook);

                MessageBox.Show("Information registerd");
                this.Open("admin panel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageName = CreateNewBook.CreateImageName()+".jpg";
            var image  = CreateNewBook.InsertImage(imageName);

            Image resize = (Image)image.GetThumbnailImage(220, 280, null, IntPtr.Zero);

            pbBookCover.Image = resize;

            

        }
    }
}
