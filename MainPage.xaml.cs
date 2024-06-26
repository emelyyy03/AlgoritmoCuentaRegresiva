namespace AlgoritmoCuentaRegresiva
{
    public partial class MainPage : ContentPage
    {
        private int count = 10;

        public MainPage()
        {
            InitializeComponent();
            cuentaRegresiva.Text = count.ToString();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            cuentaRegresiva.Text = count.ToString();

            while (count >= 1)
            {
                await Task.Delay(1000);
                count--;
                cuentaRegresiva.Text = count.ToString();
            }
        }
    }

}
