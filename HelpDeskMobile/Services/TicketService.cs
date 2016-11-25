using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using HelpDeskMobile.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace HelpDeskMobile
{
	public class TicketService
	{
		static TicketService defaultInstance = new TicketService();

		MobileServiceClient client;
		readonly IMobileServiceTable<Ticket> ticketTable;

		public TicketService()
		{
			client = new MobileServiceClient(Constants.ApplicationURL);

			ticketTable = client.GetTable<Ticket>();
		}

		public static TicketService DefaultManager
		{
			get
			{
				return defaultInstance;
			}
			private set
			{
				defaultInstance = value;
			}
		}

		public async Task<ObservableCollection<Ticket>> GetTicketsAsync()
		{
			try
			{
				IEnumerable<Ticket> tickets =
					await ticketTable.Where(t => t.Deleted == false)
									 .ToEnumerableAsync();

				return new ObservableCollection<Ticket>(tickets);
			}
			catch (MobileServiceInvalidOperationException ex)
			{
				Debug.WriteLine(@"Invalid sync operation: {0}", ex.Message);
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"Sync error: {0}", e.Message);
			}

			return null;
		}

		public async Task SaveTicketAsync(Ticket ticket)
		{
			if (ticket.Id == null)
			{
				await ticketTable.InsertAsync(ticket);
			}
			else
			{
				await ticketTable.UpdateAsync(ticket);
			}
		}
	}
}
