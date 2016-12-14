using HelpDeskMobile.Pages;
using HelpDeskMobile.ViewModels;
using Xamarin.Forms;

namespace HelpDeskMobile
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
            ViewModelBase.Init();

            // The root page of your application
            MainPage = new NavigationPage(new TicketsPage())
            {
                BarBackgroundColor = (Color)Current.Resources["Primary"],
                BarTextColor = (Color)Current.Resources["NavigationText"]
            };
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
