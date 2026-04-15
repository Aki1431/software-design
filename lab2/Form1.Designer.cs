namespace lab2
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
            txtInput = new TextBox();
            label1 = new Label();
            result = new Label();
            btnCalculateFactorial = new Button();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            label3 = new Label();
            label2 = new Label();
            lblFibResult = new Label();
            btnFib = new Button();
            txtFibInput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(90, 45);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(208, 34);
            txtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Inpput";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(35, 98);
            result.Name = "result";
            result.Size = new Size(49, 20);
            result.TabIndex = 2;
            result.Text = "Result";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(309, 49);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(89, 26);
            btnCalculateFactorial.TabIndex = 3;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(148, 165);
            txtArrayInput.Multiline = true;
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(177, 46);
            txtArrayInput.TabIndex = 4;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(331, 175);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(89, 26);
            btnCalculateSum.TabIndex = 5;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(148, 229);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(49, 20);
            lblSumResult.TabIndex = 6;
            lblSumResult.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 175);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "Input Numbers : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 55);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 11;
            label2.Text = "Input Numbers : ";
            // 
            // lblFibResult
            // 
            lblFibResult.AutoSize = true;
            lblFibResult.Location = new Point(616, 109);
            lblFibResult.Name = "lblFibResult";
            lblFibResult.Size = new Size(49, 20);
            lblFibResult.TabIndex = 10;
            lblFibResult.Text = "Result";
            // 
            // btnFib
            // 
            btnFib.Location = new Point(799, 47);
            btnFib.Name = "btnFib";
            btnFib.Size = new Size(169, 36);
            btnFib.TabIndex = 9;
            btnFib.Text = "Calculate Fibonacci";
            btnFib.UseVisualStyleBackColor = true;
            btnFib.Click += btnFib_Click_1;
            // 
            // txtFibInput
            // 
            txtFibInput.Location = new Point(616, 45);
            txtFibInput.Multiline = true;
            txtFibInput.Name = "txtFibInput";
            txtFibInput.Size = new Size(177, 46);
            txtFibInput.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 450);
            Controls.Add(label2);
            Controls.Add(lblFibResult);
            Controls.Add(btnFib);
            Controls.Add(txtFibInput);
            Controls.Add(label3);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label1;
        private Label result;
        private Button btnCalculateFactorial;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Label label3;
        private Label label2;
        private Label lblFibResult;
        private Button btnFib;
        private TextBox txtFibInput;
    }
}
