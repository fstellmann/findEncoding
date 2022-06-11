using System;
using System.Text;
using System.Windows.Forms;

namespace findEncoding
{
    class Program
    {
        private static string path;
        [STAThread]
        static void Main(string[] args)
        {
            var ofd = new OpenFileDialog();

            ofd.ShowDialog();
            path = ofd.FileName;
            try
            {
                Encoding encoding = path.GetEncoding();
                MessageBox.Show($"Detected Encoding {encoding.EncodingName} for file {path}");
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
