using HelpDeskMobile.ViewModels;
using Xamarin.Forms;

namespace HelpDeskMobile.Pages
{
	public partial class TicketListPage : ContentPage
	{
		public TicketListPage()
		{
			InitializeComponent();

			BindingContext = new TicketListViewModel();
		}
	}
}
