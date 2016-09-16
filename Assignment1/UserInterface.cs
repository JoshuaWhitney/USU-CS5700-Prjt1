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
                Filter = @"Database files (*.xml, *.json)|*.xml;*.json",
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
            else if (jsonFileType.Checked)
                storageStrategy = new JsonImporterExporterStrategy();
            else
                MessageBox.Show(@"Please Select File Type");

            var processor = new Processor()
                {
                    StorageStrategy = storageStrategy,
                    InputFileName = inputFilename.Text,
                };

            // Run the analyzer
            processor.Run();

            // Display the result;
            /*
            beginningBalance.Text = FormatToDollars(analyzer.BeginningTotal);
            endingBalance.Text = FormatToDollars(analyzer.EndingTotal);
            interestPaid.Text = FormatToDollars(analyzer.InterestPaid);
            feesCollected.Text = FormatToDollars(analyzer.FeesCollected);
            */
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exiting");
        }
    }
}
