namespace CS162_Lab2.Apps
{
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void translateButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string inputString = inputTextBox.Text;
                string[] inputSplit = inputString.Split(null);

                string newString = "";

                foreach (var stringSplit in inputSplit)
                {
                    char[] tokenalizedString = stringSplit.ToCharArray();

                    char firstChar = tokenalizedString[0];

                    foreach (var charItem in tokenalizedString)
                    {
                        if(charItem == firstChar) { continue; }
                        newString += char.ToUpper(charItem);
                    }
                    newString = newString + $"{char.ToUpper(firstChar)}AY ";

                }

                displayLabel.Text = newString;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
