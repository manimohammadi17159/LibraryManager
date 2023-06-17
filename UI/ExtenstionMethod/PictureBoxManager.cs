using Domain.Model;
using System.Windows.Forms;

namespace UI.ExtenstionMethod
{
    internal static class PictureBoxManager
    {

        public static List<PictureBox> ConvertToPictureBoxShop(this List<Book> books, int x, int y)
        {
            int index = 0;
            int i = 1;
            List<PictureBox> result = new List<PictureBox>();

            foreach (var book in books)
            {
                string path = books[index].ImageAddress;

                Bitmap image = new($"C:\\Users\\ASUS\\OneDrive\\Desktop\\Windos Form Project\\image\\{path}");

                Image resize = (Image)image.GetThumbnailImage(220, 280, null, IntPtr.Zero);

                result.Add(new PictureBox()
                {
                    Name = books[index].Name,
                    Image = (Image)resize,
                    Location = new Point(x, y),
                    Height = resize.Height,
                    Width = resize.Width,

                }); ;

                i++;
                x += 330;
                index++;

                if (i == 3)
                {
                    y += 330;
                    x = 30;
                    i = 1;
                }

            }
            return result;

        }
        public static List<PictureBox> ConvertToPictureBoxProfile(this List<Book> books, int x, int y)
        {
            int index = 0;
            int i = 1;
            List<PictureBox> result = new List<PictureBox>();

            foreach (var book in books)
            {
                string path = books[index].ImageAddress;

                Bitmap image = new($"C:\\Users\\ASUS\\OneDrive\\Desktop\\Windos Form Project\\image\\{path}");

                Image resize = (Image)image.GetThumbnailImage(110, 140, null, IntPtr.Zero);

                result.Add(new PictureBox()
                {
                    Name = books[index].Name,
                    Image = resize,
                    Location = new Point(x, y),
                    Height = resize.Height,
                    Width = resize.Width
                });

                i++;
                x += 150;
                index++;

                if (i == 4)
                {
                    y += 200;
                    x = 30;
                    i = 1;
                }

            }
            return result;

        }
        public static void ShowInPanel(this Panel panel, List<PictureBox> books)
        {
            foreach (var book in books)
            {
                panel.Controls.Add(book);
            }

        }

    }
}
