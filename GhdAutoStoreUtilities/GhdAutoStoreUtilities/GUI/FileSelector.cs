using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    [DefaultEvent("SelectedFile")]
    public partial class FileSelector : UserControl
    {
        public event EventHandler SelectedFile;

        public string SelectedFileName => fileDialog.FileName;

        public string FileType
        {
            get => fileDialog.Filter;
            set => fileDialog.Filter = value;
        }

        public string ButtonText
        {
            get => selectFileButton.Text;
            set => selectFileButton.Text = value;
        }

        public Size ButtonSize
        {
            get => selectFileButton.Size;
            set => selectFileButton.Size = value;
        }

        public FileSelector()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fileDialog.FileName))
            {
                fileNameLabel.Text = fileDialog.FileName;
                SelectedFile?.Invoke(this, e);
            }
            else
            {
                fileNameLabel.Text = "No file selected";
            }
        }
    }
}
