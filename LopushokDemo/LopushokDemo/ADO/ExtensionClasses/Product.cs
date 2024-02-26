using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace LopushokDemo.ADO
{
    public partial class Product
    {
        public ImageSource ImageSource
        {
            get
            {
                var bitmap = new BitmapImage();
                byte[] bytes;

                if (Image == null || Image == "" || Image == "нет" || Image == "не указано")
                {
                    bytes = File.ReadAllBytes(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName +
                                              $"\\Resources\\products\\picture.png");
                }
                else
                {
                    bytes = File.ReadAllBytes(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName +
                                              $"\\Resources\\{Image}");
                }

                var ms = new MemoryStream(bytes);


                bitmap.BeginInit();
                bitmap.StreamSource = ms;
                bitmap.EndInit();
                return bitmap;
            }
        }
    }
}
