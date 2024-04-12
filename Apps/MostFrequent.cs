namespace CS162_Lab2.Apps
{
    public partial class MostFrequent : Form
    {
        public MostFrequent()
        {
            InitializeComponent();
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string input = inputTextBox.Text;
                char[] tokenalizedInput = input.ToCharArray();

                int count = 0;
                char mostChar = 'a';
              
                for(int i = 0; i < tokenalizedInput.Length; i++)
                {
                    if (tokenalizedInput[i] == ' ') { continue; }

                    int tempCount = 0;
                    foreach (var item in tokenalizedInput)
                    {
                        if (tokenalizedInput[i] == item)
                        {
                            tempCount++;
                        }
                    }

                    if(tempCount > count) { 
                        count = tempCount;
                        mostChar = tokenalizedInput[i];
                    }
                }

                displayLabel.Text = mostChar.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
