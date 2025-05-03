namespace OOPFinal
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            Task load = AutoIncrementProgressBar();
        }

        private async Task AutoIncrementProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5; 
                await Task.Delay(200);   
            }
            this.Hide();
            new MainMenu02().Show();
        }

        
    }
}
