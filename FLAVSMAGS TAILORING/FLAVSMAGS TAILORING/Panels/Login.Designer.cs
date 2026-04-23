namespace FLAVSMAGS_TAILORING
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(458, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 552);
            panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 403);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 352);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(93, 406);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(114, 352);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(469, 552);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Firebrick;
            iconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            iconButton1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.LaptopFile;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(159, 17);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(113, 39);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Login";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(159, 170);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(72, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 233);
            panel2.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 554);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLAVSMAGS Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel2;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
