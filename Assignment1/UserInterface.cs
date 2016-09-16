using System;
using System.IO;
using Assignment1.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = @"XML files (*.xml)|*.xml",
                Multiselect = false
            };
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
                inputFilename.Text = dlg.FileName;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputFilename.Text))
            {
                MessageBox.Show(@"Input filename cannot be empty");
                return;
            }

            if (!File.Exists(inputFilename.Text))
            {
                MessageBox.Show(@"Input file must exist");
                return;
            }

            ImportExporterStrategy storageStrategy = null;
            if (xmlFileType.Checked)
                storageStrategy = new XmlImportExportStrategy();
            else
                storageStrategy = new JsonImporterExporterStrategy();

            var analyzer = new Analyzer()
            {
                StorageStrategy = storageStrategy,
                InputFileName = inputFilename.Text,
                InterestStrategy = CreateInterestStrategy(),
                FeeStrategy = CreateFeeStrategy()
            };

            // Run the analyzer
            analyzer.Run();

            // Display the result;
            beginningBalance.Text = FormatToDollars(analyzer.BeginningTotal);
            endingBalance.Text = FormatToDollars(analyzer.EndingTotal);
            interestPaid.Text = FormatToDollars(analyzer.InterestPaid);
            feesCollected.Text = FormatToDollars(analyzer.FeesCollected);
        }
    }
}
