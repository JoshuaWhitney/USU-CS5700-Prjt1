namespace Assignment1
{
    partial class UserInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jsonFileType = new System.Windows.Forms.RadioButton();
            this.xmlFileType = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.inputFilename = new System.Windows.Forms.TextBox();
            this.inputFilenameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jsonFileType);
            this.groupBox1.Controls.Add(this.xmlFileType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 45);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // jsonFileType
            // 
            this.jsonFileType.AutoSize = true;
            this.jsonFileType.Location = new System.Drawing.Point(99, 19);
            this.jsonFileType.Name = "jsonFileType";
            this.jsonFileType.Size = new System.Drawing.Size(53, 17);
            this.jsonFileType.TabIndex = 1;
            this.jsonFileType.TabStop = true;
            this.jsonFileType.Text = "JSON";
            this.jsonFileType.UseVisualStyleBackColor = true;
            // 
            // xmlFileType
            // 
            this.xmlFileType.AutoSize = true;
            this.xmlFileType.Location = new System.Drawing.Point(23, 19);
            this.xmlFileType.Name = "xmlFileType";
            this.xmlFileType.Size = new System.Drawing.Size(47, 17);
            this.xmlFileType.TabIndex = 0;
            this.xmlFileType.TabStop = true;
            this.xmlFileType.Text = "XML";
            this.xmlFileType.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(254, 96);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(15, 96);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(126, 23);
            this.runButton.TabIndex = 27;
            this.runButton.Text = "Load and run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(297, 64);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 23);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // inputFilename
            // 
            this.inputFilename.Location = new System.Drawing.Point(97, 66);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(194, 20);
            this.inputFilename.TabIndex = 25;
            this.inputFilename.Text = "BankAccounts.xml";
            // 
            // inputFilenameLabel
            // 
            this.inputFilenameLabel.AutoSize = true;
            this.inputFilenameLabel.Location = new System.Drawing.Point(12, 69);
            this.inputFilenameLabel.Name = "inputFilenameLabel";
            this.inputFilenameLabel.Size = new System.Drawing.Size(79, 13);
            this.inputFilenameLabel.TabIndex = 24;
            this.inputFilenameLabel.Text = "Input Filename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.inputFilename);
            this.Controls.Add(this.inputFilenameLabel);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton jsonFileType;
        private System.Windows.Forms.RadioButton xmlFileType;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox inputFilename;
        private System.Windows.Forms.Label inputFilenameLabel;
        private System.Windows.Forms.Label label1;
    }
}

