
using HelpDeskMobile.Helpers;
using HelpDeskMobile.Models;
using Xamarin.Forms;

namespace HelpDeskMobile.Cells
{
	public class TicketCell : ViewCell
	{
		readonly INavigation navigation;

		public TicketCell(INavigation navigation = null)
		{
			Height = 120;
			View = new TicketCellView();
			this.navigation = navigation;
		}

		protected override async void OnTapped()
		{
			base.OnTapped();
			if (navigation == null)
				return;
			var ticket = BindingContext as Ticket;
			if (ticket == null)
				return;

			await NavigationService.PushAsync(navigation, new TicketDetailsPage(ticket));
		}
	}

	public partial class TicketCellView : ContentView
	{
		public TicketCellView()
		{
			InitializeComponent();
		}
	}
}
