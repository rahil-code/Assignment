namespace Group_6_Flights_Application
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Group_6_Flights_Application" };
        }
    }
}
