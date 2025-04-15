namespace N12__YP__Task_4_12._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            char targetChar = 'à';
            if (!string.IsNullOrEmpty(txtSymbol.Text))
            {
                targetChar = txtSymbol.Text[0];
            }
            int count = CountOccurrences(txtInput.Text, targetChar);
            txtResult.Text = count.ToString();
        }

        private int CountOccurrences(string input, char target)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == target) count++;
            }
            return count;
        }
    }
}
