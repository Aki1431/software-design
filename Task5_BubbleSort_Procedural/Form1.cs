namespace Task5_BubbleSort_Procedural
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Text.Split(',');
            int[] numbers = Array.ConvertAll(input, int.Parse);

            BubbleSort(numbers);

            lblResult.Text = string.Join(",", numbers);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
