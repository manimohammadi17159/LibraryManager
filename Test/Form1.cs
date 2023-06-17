using System.Drawing;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var pic in pictures)
            {
                this.Show(pic.pictureBox);
            }
            
        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG(*.JPG)|*.jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Image myImage = Image.FromFile(save.FileName);
                pictureBox1.Image = myImage;

                int lastPic = this.pictures.Count;
                pictures[lastPic++].pictureBox.Image = myImage;
              
                
            }
        }
    }
}