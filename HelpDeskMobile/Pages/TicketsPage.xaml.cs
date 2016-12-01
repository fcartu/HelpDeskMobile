using HelpDeskMobile.ViewModels;
using Xamarin.Forms;

namespace HelpDeskMobile.Pages
{
	public partial class TicketsPage : ContentPage
	{
		public TicketsPage()
		{
			InitializeComponent();

			BindingContext = new TicketListViewModel();
		}
	}
}
