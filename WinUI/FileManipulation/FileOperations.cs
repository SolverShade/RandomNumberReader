using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.FileManipulation
{
    public static class FileOperations
    {
        public static string FindFileName(OpenFileDialog openFileDialouge)
        {
            FileContent file = new FileContent(openFileDialouge);

            string path = file.GetTextFile();

            if(path != null)
            {
                return path;
            }
            else
            {
                return null;
            }
        }
    }
}
