using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class BinAnalysisOperationForm : Form
    {
        public BinAnalysisResults AnalysisResults { get; private set; }

        private readonly string synqFilePath;
        private readonly string asFilePath;

        private Task operationTask;

        private readonly CancellationTokenSource tokenSource;

        public BinAnalysisOperationForm(string synqFilePath, string asFilePath)
        {
            InitializeComponent();
            AnalysisResults = null;
            this.synqFilePath = synqFilePath;
            this.asFilePath = asFilePath;
            tokenSource = new CancellationTokenSource();
        }

        private IGridFileReader GetGridFileReader(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension switch
            {
                ".xlsx" => new ExcelReader(filePath),
                ".csv" => new SeparatedValueReader(filePath, '\t'),
                _ => throw new ArgumentException("Unsupported extension: " + extension),
            };
        }

        private async void MissingBinOperationForm_Shown(object sender, EventArgs e)
        {
            CancellationToken token = tokenSource.Token;
            // lambda needs to be async in order to catch exceptions
            operationTask = Task.Run(async () =>
            {
                token.ThrowIfCancellationRequested();
                using IGridFileReader synqData = GetGridFileReader(synqFilePath);
                token.ThrowIfCancellationRequested();
                using IGridFileReader asData = GetGridFileReader(asFilePath);
                token.ThrowIfCancellationRequested();
                SynqDataReader synqReader = new SynqDataReader(synqData);
                AutoStoreDataReader asReader = new AutoStoreDataReader(asData);
                token.ThrowIfCancellationRequested();
                AnalysisResults = new BinAnalysisResults(
                    MissingBinFinder.GetMissingBins(synqReader, asReader, true),
                    MismatchedBinLocationFinder.GetMismatchedBins(synqReader, asReader, true));
                token.ThrowIfCancellationRequested();
            });
            try
            {
                await operationTask;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                if (!(ex is OperationCanceledException))
                {
                    Console.WriteLine(ex.ToString());
                    progressBar.Enabled = false;
                    MessageBox.Show(ex.Message, "Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult = DialogResult.Cancel;
            }
        }

        private async void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Enabled = false;
            progressLabel.Text = "Cancelling...";
            tokenSource.Cancel();
            /*try
            {
                await operationTask;
            }
            catch (Exception) { }*/
            DialogResult = DialogResult.Cancel;
        }

        private void MissingBinOperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
        }
    }
}
