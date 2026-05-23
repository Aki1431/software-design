namespace lab3
{
    partial class Lab3New
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
            displayListBox = new ListBox();
            btnShowAll = new Button();
            btnShowStats = new Button();
            SuspendLayout();
            // 
            // displayListBox
            // 
            displayListBox.BackColor = Color.Black;
            displayListBox.ForeColor = Color.Lime;
            displayListBox.FormattingEnabled = true;
            displayListBox.Location = new Point(39, 30);
            displayListBox.Name = "displayListBox";
            displayListBox.Size = new Size(923, 444);
            displayListBox.TabIndex = 0;
            displayListBox.SelectedIndexChanged += displayListBox_SelectedIndexChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.ForeColor = Color.Cyan;
            btnShowAll.Location = new Point(142, 561);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(189, 29);
            btnShowAll.TabIndex = 1;
            btnShowAll.Text = "📚 Show All Books";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnShowStats
            // 
            btnShowStats.Location = new Point(568, 561);
            btnShowStats.Name = "btnShowStats";
            btnShowStats.Size = new Size(189, 29);
            btnShowStats.TabIndex = 2;
            btnShowStats.Text = "📊 Show Statistics";
            btnShowStats.UseVisualStyleBackColor = true;
            btnShowStats.Click += btnShowStats_Click;
            // 
            // Lab3New
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1015, 670);
            Controls.Add(btnShowStats);
            Controls.Add(btnShowAll);
            Controls.Add(displayListBox);
            ForeColor = Color.Lime;
            Name = "Lab3New";
            Text = "Lab3New";
            ResumeLayout(false);
        }

        #endregion

        private ListBox displayListBox;
        private Button btnShowAll;
        private Button btnShowStats;
    }
}