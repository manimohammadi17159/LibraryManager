using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ExtenstionMethod
{
    internal static class CreateNewBook
    {
        public static Image InsertImage(string imageName) 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif;";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Multiselect = false;
            Image result = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = imageName;
                byte[] imageData = File.ReadAllBytes(openFileDialog.FileName);
                string folderPath = @"C:\Users\ASUS\OneDrive\Desktop\Windos Form Project\image";
                string filePath = Path.Combine(folderPath, name);


                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }


                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    stream.Write(imageData, 0, imageData.Length);
                }
                result = new Bitmap(openFileDialog.FileName);

            }
            return result;

        }
        public static string CreateImageName() 
        {
            string result = Guid.NewGuid().ToString();

            return result;
        
        }
        public static bool CheckInfo(this TextBox textBox)
        {
            string text = textBox.Text;
            bool result = text.Length> 6 && text.Length < 20 ? false : true;

            return result;
        }

    }
}
