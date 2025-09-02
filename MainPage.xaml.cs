namespace TARgv24
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string text = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                if (count<10) { text = "1. ---- numbers"; }
                else if (count < 100) { text = "2. ---- numbers"; }
                else if (count < 1000) { text = "3. ---- numbers"; }
                else if (count < 10000) { text = "4. ---- numbers"; }
                else if (count < 100000) { text = "5. ---- numbers"; }
            CounterBtn.Text = $"Clicked {count} times \n {text} ";

            SemanticScreenReader.Announce(CounterBtn.Text);
Советую выходить из гитхаба
        }
    }
}
