namespace DataEntryAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectionStringLabel_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    fileChooseTextbox.Text = openFileDialog.FileName;
                }
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // Retrieve the values from the form
            string connectionString = connectionStringBox.Text;
            string tableName = tableNameTextBox.Text;
            string[] columnNames = columnNamesTextbox.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(name => name.Trim())
                                                       .ToArray();
            string csvFilePath = fileChooseTextbox.Text;
            bool skipFirstColumn = checkBox1.Checked; // Assuming you have a CheckBox named chkSkipFirstColumn

            // Validate inputs (example method, you need to implement it)
            if (ValidateInputs(connectionString, tableName, columnNames, csvFilePath))
            {
                // Initialize the logic class with the inputs
                DataEntryLogic dataEntryLogic = new DataEntryLogic(connectionString, tableName, columnNames);

                // Process the CSV file
                dataEntryLogic.ProcessCsvFile(csvFilePath, skipFirstColumn);
            }
            else
            {
                MessageBox.Show("Please check your inputs and try again.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Check changes in the database.", "Finished.", MessageBoxButtons.OK);
        }

        private bool ValidateInputs(string connectionString, string tableName, string[] columnNames, string csvFilePath)
        {
            // Implement validation logic here
            // For example, check if strings are not empty and if the file path points to an existing file
            return !string.IsNullOrEmpty(connectionString)
                && !string.IsNullOrEmpty(tableName)
                && columnNames.Length > 0
                && File.Exists(csvFilePath);
        }
    }
}