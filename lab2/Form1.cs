namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            this.result.Text = $"Factorial: {result}";

        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }
        public int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void btnFib_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibInput.Text);
            int result = Fibonacci(n);

            lblFibResult.Text = $"Fibonacci({n}) = {result}";
        }

        private void btnFib_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibInput.Text);
            int result = Fibonacci(n);

            lblFibResult.Text = $"Fibonacci({n}) = {result}";
        }
    }
}
