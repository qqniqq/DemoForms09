using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DemoForms.Helpers
{
    public static class ImageHelper
    {
        public static Image GetProductImage(
            string imageName)
        {
            string path =
                Path.Combine(
                    Application.StartupPath,
                    "Images",
                    imageName);

            if (File.Exists(path))
            {
                return Image.FromFile(path);
            }

            return Properties.Resources.picture;
        }
    }
}