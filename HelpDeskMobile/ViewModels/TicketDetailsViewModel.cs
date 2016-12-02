using System;
using HelpDeskMobile.Models;
using Xamarin.Forms;

namespace HelpDeskMobile
{
	public class TicketDetailsViewModel
	{
		Ticket ticket;
		public Ticket Ticket
		{
			get { return ticket; }
			set { ticket = value; }
		}

		protected INavigation Navigation { get; }

		public TicketDetailsViewModel(INavigation navigation, Ticket ticket)
		{
			Ticket = ticket;
			this.Navigation = navigation;
		}
	}
}
