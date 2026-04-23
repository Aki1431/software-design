using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FLAVSMAGS_TAILORING
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Load GIF into pictureBox2
            try
            {
                string gifPath = @"C:\Users\James\Downloads\Video 1.gif";
                if (System.IO.File.Exists(gifPath))
                {
                    pictureBox2.Image = Image.FromFile(gifPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading GIF: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40; // Adjust this value for more/less curve (20-60 recommended)
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = this.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                Dashboard dash = new Dashboard();
                dash.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}