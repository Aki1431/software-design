namespace Task4
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
            listBoxResults = new ListBox();
            Sort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(355, 102);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(392, 274);
            listBoxResults.TabIndex = 0;
            listBoxResults.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Sort
            // 
            Sort.Location = new Point(123, 102);
            Sort.Name = "Sort";
            Sort.Size = new Size(174, 84);
            Sort.TabIndex = 1;
            Sort.Text = "Sort";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button Sort;
    }
}
