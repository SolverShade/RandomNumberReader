using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.FileManipulation
{
    public class FileContent
    {
        public OpenFileDialog OpenFile {get; set;}
        public FileContent(OpenFileDialog openFile)
        {
            OpenFile = openFile; 
        }

        public string GetTextFile()
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFile.FileName;
                    return path;
                }
                catch
                {
                    throw new Exception("The file given was invalid. make sure it is a non-blank txt");
                }
            }
            else
            {
                return null;
            }
                   
        }

        
    }
}
