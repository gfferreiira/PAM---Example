namespace Teste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string nome = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnNameClicked(Object sender, EventArgs e)
        {
            nome = NameEntry.Text;
            GreetingLabel.Text = $"Hello, {nome}!!";

            if (nome == null || nome == "")
            {
                GreetingLabel.Text = "Hello, World!!";
            }

            SemanticScreenReader.Announce(GreetingLabel.Text);
        }
    }

}
