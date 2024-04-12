using CS162_Lab2.Apps;

namespace CS162_Lab2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mostFrequentButton_Click(object sender, EventArgs e)
        {
            Form form = new MostFrequent();
            form.Show();
        }

        private void pigLatinButton_Click(object sender, EventArgs e)
        {
            Form form = new PigLatin();
            form.Show();
        }
    }
}
