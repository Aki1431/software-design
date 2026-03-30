namespace Task5_Descending_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Sorter
        {
            public int[] SortDescending(int[] arr)
            {
                Array.Sort(arr);   // sort ascending first
                Array.Reverse(arr); // then reverse to descending
                return arr;
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Text.Split(',');
            int[] numbers = Array.ConvertAll(input, int.Parse);

            Sorter sorter = new Sorter();
            int[] result = sorter.SortDescending(numbers);

            lblResult.Text = string.Join(",", result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
