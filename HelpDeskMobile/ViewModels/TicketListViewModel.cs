﻿using System;
using System.Collections.ObjectModel;
using HelpDeskMobile.Models;
using Xamarin.Forms;

namespace HelpDeskMobile.ViewModels
{
	public class TicketListViewModel
	{
		public ObservableCollection<Ticket> Tickets { get; set; }

		public bool IsBusy { get; set; }

		public Command AddNewTicketCommand { get; set; }

		public Command RefreshTicketsCommand { get; set; }

		public TicketListViewModel(bool isDesignMode = false)
		{
			Tickets = new ObservableCollection<Ticket>();
			IsBusy = false;

			AddNewTicketCommand = new Command(x => AddNewTicket());
			RefreshTicketsCommand = new Command(x => RefreshTickets());

			if (isDesignMode)
			{
				Tickets = new ObservableCollection<Ticket>();
				Tickets.Add(
					new Ticket()
					{
						Id = "1",
						TicketId = "1000",
						Title = "User cannot login to the system",
						CreatedAt = new DateTime(2016, 11, 22, 6, 15, 45).ToString(),
						Priority = "High",
						Username = "rguerra"
					});
				Tickets.Add(
					new Ticket()
					{
						Id = "2",
						TicketId = "1001",
						Title = "Ticket test 2",
						CreatedAt = new DateTime(2016, 11, 24, 15, 41, 20).ToString(),
						Priority = "Low",
						Username = "pperez"
				}
			);
			}
		}

		void AddNewTicket()
		{
			throw new NotImplementedException();
		}

		void RefreshTickets()
		{
			throw new NotImplementedException();
		}
	}
}