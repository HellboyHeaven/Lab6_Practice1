namespace FileBrowser
{
    partial class FileBrowserForm
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
            openButton = new Button();
            resultTextBox = new TextBox();
            nextButton = new Button();
            closeButton = new Button();
            openFileDialog = new OpenFileDialog();
            previousButton = new Button();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(8, 7);
            openButton.Margin = new Padding(2, 2, 2, 2);
            openButton.Name = "openButton";
            openButton.Size = new Size(78, 20);
            openButton.TabIndex = 0;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(8, 36);
            resultTextBox.Margin = new Padding(2, 2, 2, 2);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(541, 228);
            resultTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(101, 7);
            nextButton.Margin = new Padding(2, 2, 2, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(78, 20);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(471, 7);
            closeButton.Margin = new Padding(2, 2, 2, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(78, 20);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(194, 6);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 23);
            previousButton.TabIndex = 4;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // FileBrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(previousButton);
            Controls.Add(closeButton);
            Controls.Add(nextButton);
            Controls.Add(resultTextBox);
            Controls.Add(openButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FileBrowserForm";
            Text = "File Browser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private TextBox resultTextBox;
        private Button nextButton;
        private Button closeButton;
        private OpenFileDialog openFileDialog;
        private Button previousButton;
    }
}
