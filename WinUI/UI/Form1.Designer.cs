
namespace WinUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalListBox = new System.Windows.Forms.ListBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.numbersAddedLabel = new System.Windows.Forms.Label();
            this.numbersAddedListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.FileName = ".txt";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(76, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "-Random Number Reader-";
            // 
            // totalListBox
            // 
            this.totalListBox.FormattingEnabled = true;
            this.totalListBox.Location = new System.Drawing.Point(12, 126);
            this.totalListBox.Name = "totalListBox";
            this.totalListBox.Size = new System.Drawing.Size(273, 30);
            this.totalListBox.TabIndex = 1;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(104, 48);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 23);
            this.readFileButton.TabIndex = 2;
            this.readFileButton.Text = "Select File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.CalculateNumberFileMetrics_Button);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(123, 97);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // numbersAddedLabel
            // 
            this.numbersAddedLabel.AutoSize = true;
            this.numbersAddedLabel.Location = new System.Drawing.Point(101, 169);
            this.numbersAddedLabel.Name = "numbersAddedLabel";
            this.numbersAddedLabel.Size = new System.Drawing.Size(83, 13);
            this.numbersAddedLabel.TabIndex = 5;
            this.numbersAddedLabel.Text = "Numbers Added";
            // 
            // numbersAddedListBox
            // 
            this.numbersAddedListBox.FormattingEnabled = true;
            this.numbersAddedListBox.Location = new System.Drawing.Point(12, 196);
            this.numbersAddedListBox.Name = "numbersAddedListBox";
            this.numbersAddedListBox.Size = new System.Drawing.Size(273, 30);
            this.numbersAddedListBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 244);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 269);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.numbersAddedLabel);
            this.Controls.Add(this.numbersAddedListBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.totalListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Random Number Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox totalListBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label numbersAddedLabel;
        private System.Windows.Forms.ListBox numbersAddedListBox;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label statusLabel;
    }
}

