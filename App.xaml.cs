namespace TARgv24
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage MainPage = new NavigationPage(new AppShell()); //added new Navigation address//

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}