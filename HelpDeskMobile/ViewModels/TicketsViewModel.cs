using System;
using System.Collections.ObjectModel;
using HelpDeskMobile.Models;
using Xamarin.Forms;

namespace HelpDeskMobile.ViewModels
{
	public class TicketsViewModel
	{
		public ObservableCollection<Ticket> Tickets { get; set; }

		public bool IsBusy { get; set; }

		public Command AddNewTicketCommand { get; set; }

		public Command GetTicketsFromServerCommand { get; set; }

		public TicketsViewModel()
		{
			Tickets = new ObservableCollection<Ticket>();
			IsBusy = false;

			AddNewTicketCommand = new Command(x => AddNewTicket());
			GetTicketsFromServerCommand = new Command(x => GetTicketsFromServer());
		}

		void AddNewTicket()
		{
			throw new NotImplementedException();
		}

		void GetTicketsFromServer()
		{
			throw new NotImplementedException();
		}
	}
}
