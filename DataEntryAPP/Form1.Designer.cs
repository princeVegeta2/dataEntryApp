namespace DataEntryAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            connectionStringBox = new TextBox();
            connectionStringLabel = new Label();
            tableNameTextBox = new TextBox();
            tableNameLabel = new Label();
            columnNamesTextbox = new TextBox();
            columnNamesLabel = new Label();
            columnNamesTooltip = new ToolTip(components);
            fileChooseLabel = new Label();
            browseButton = new Button();
            fileChooseTextbox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            processButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // connectionStringBox
            // 
            connectionStringBox.Location = new Point(132, 12);
            connectionStringBox.Name = "connectionStringBox";
            connectionStringBox.Size = new Size(656, 27);
            connectionStringBox.TabIndex = 0;
            connectionStringBox.Text = "Server=YourServerName;Database=YourDATABASE;Trusted_Connection=True;";
            // 
            // connectionStringLabel
            // 
            connectionStringLabel.AutoSize = true;
            connectionStringLabel.Location = new Point(-2, 15);
            connectionStringLabel.Name = "connectionStringLabel";
            connectionStringLabel.Size = new Size(128, 20);
            connectionStringLabel.TabIndex = 1;
            connectionStringLabel.Text = "Connection string:";
            connectionStringLabel.Click += connectionStringLabel_Click;
            // 
            // tableNameTextBox
            // 
            tableNameTextBox.Location = new Point(132, 45);
            tableNameTextBox.Name = "tableNameTextBox";
            tableNameTextBox.Size = new Size(205, 27);
            tableNameTextBox.TabIndex = 2;
            // 
            // tableNameLabel
            // 
            tableNameLabel.AutoSize = true;
            tableNameLabel.Location = new Point(-2, 52);
            tableNameLabel.Name = "tableNameLabel";
            tableNameLabel.Size = new Size(88, 20);
            tableNameLabel.TabIndex = 3;
            tableNameLabel.Text = "Table name:";
            // 
            // columnNamesTextbox
            // 
            columnNamesTextbox.Location = new Point(132, 78);
            columnNamesTextbox.Multiline = true;
            columnNamesTextbox.Name = "columnNamesTextbox";
            columnNamesTextbox.Size = new Size(656, 34);
            columnNamesTextbox.TabIndex = 4;
            columnNamesTooltip.SetToolTip(columnNamesTextbox, "Enter column names separated by a comma.");
            // 
            // columnNamesLabel
            // 
            columnNamesLabel.AutoSize = true;
            columnNamesLabel.Location = new Point(-2, 92);
            columnNamesLabel.Name = "columnNamesLabel";
            columnNamesLabel.Size = new Size(110, 20);
            columnNamesLabel.TabIndex = 5;
            columnNamesLabel.Text = "Column names:";
            // 
            // fileChooseLabel
            // 
            fileChooseLabel.AutoSize = true;
            fileChooseLabel.Location = new Point(-2, 129);
            fileChooseLabel.Name = "fileChooseLabel";
            fileChooseLabel.Size = new Size(179, 20);
            fileChooseLabel.TabIndex = 6;
            fileChooseLabel.Text = "Select the data file (.CSV):";
            // 
            // browseButton
            // 
            browseButton.Location = new Point(183, 125);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(94, 29);
            browseButton.TabIndex = 7;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // fileChooseTextbox
            // 
            fileChooseTextbox.Location = new Point(283, 126);
            fileChooseTextbox.Name = "fileChooseTextbox";
            fileChooseTextbox.Size = new Size(491, 27);
            fileChooseTextbox.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "fileChooseOpenFileDialogue";
            openFileDialog1.Filter = "CSV files (.csv)|.csv";
            // 
            // processButton
            // 
            processButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            processButton.Location = new Point(12, 197);
            processButton.Name = "processButton";
            processButton.Size = new Size(147, 43);
            processButton.TabIndex = 9;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(183, 171);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(239, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Skip first column of the CSV file";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(processButton);
            Controls.Add(fileChooseTextbox);
            Controls.Add(browseButton);
            Controls.Add(fileChooseLabel);
            Controls.Add(columnNamesLabel);
            Controls.Add(columnNamesTextbox);
            Controls.Add(tableNameLabel);
            Controls.Add(tableNameTextBox);
            Controls.Add(connectionStringLabel);
            Controls.Add(connectionStringBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox connectionStringBox;
        private Label connectionStringLabel;
        private TextBox tableNameTextBox;
        private Label tableNameLabel;
        private TextBox columnNamesTextbox;
        private Label columnNamesLabel;
        private ToolTip columnNamesTooltip;
        private Label fileChooseLabel;
        private Button browseButton;
        private TextBox fileChooseTextbox;
        private OpenFileDialog openFileDialog1;
        private Button processButton;
        private CheckBox checkBox1;
    }
}