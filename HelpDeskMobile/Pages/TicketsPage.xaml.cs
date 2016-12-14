using HelpDeskMobile.Helpers;
using HelpDeskMobile.Models;
using HelpDeskMobile.ViewModels;
using Xamarin.Forms;

namespace HelpDeskMobile.Pages
{
	public partial class TicketsPage : ContentPage
	{
		public TicketsPage()
		{
			InitializeComponent();

			BindingContext = new TicketListViewModel(Navigation);

			ListViewTickets.ItemSelected += async (sender, e) => 
			{
				var ticket = ListViewTickets.SelectedItem as Ticket;
				if (ticket == null)
					return;

				var sessionDetails = new TicketDetailsPage(ticket);

				await NavigationService.PushAsync(Navigation, sessionDetails);
				ListViewTickets.SelectedItem = null;
			};
		}

		void ListViewTapped(object sender, ItemTappedEventArgs e)
		{
			var list = sender as ListView;
			if (list == null)
				return;
			list.SelectedItem = null;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			ListViewTickets.ItemTapped += ListViewTapped;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			ListViewTickets.ItemTapped -= ListViewTapped;
		}
	}
}
