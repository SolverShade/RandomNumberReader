using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.FileManipulation;
using WinUI.Math.Helpers;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateNumberFileMetrics_Button(object sender, EventArgs e)
        {
            string filePath = FileOperations.FindFileName(openFile); //open file is the name of the OpenFileDialouge made in the Fourm Creator

            if(filePath == null)
            {
                statusLabel.Text = "Status: Please Enter A Valid File";
                return;
            }

            List<int> selectedFileNumbers = TextFileDecoder.ExtractWholeNumbers(filePath);

            CalculateAndDisplayNumberMetrics(selectedFileNumbers);           
        }

        private void CalculateAndDisplayNumberMetrics(List<int> selectedFileNumbers)
        {
            int total = BasicMath.getSumOfNumbers(selectedFileNumbers);
            int quantity = BasicMath.getAmountOfWholeNumbers(selectedFileNumbers);

            totalListBox.Items.Add(total);
            numbersAddedListBox.Items.Add(quantity);

            statusLabel.Text = "Status: Success!";
        }
    }
}
