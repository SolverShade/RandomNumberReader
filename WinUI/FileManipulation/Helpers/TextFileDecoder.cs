using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.FileManipulation
{
    public static class TextFileDecoder
    {
        public static List<int> ExtractWholeNumbers(string filePath)
        {
            List<int> extractedNumbers = new List<int>();

            foreach(string line in File.ReadLines(filePath))
            {
                bool wasNumber = int.TryParse(line, out int retrivedNumber);

                if (wasNumber)
                {
                    extractedNumbers.Add(retrivedNumber); //currently skips any non-integer value. not sure if thats enough error checking. 
                }
                
            }

            return extractedNumbers;
        }
    }
}
