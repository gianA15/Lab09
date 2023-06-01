using Xamarin.Forms;

namespace Lab09
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }

        public static float ScreenWidth { get; set; }


        public App()
        {
            InitializeComponent();

            MainPage = new PinchDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
