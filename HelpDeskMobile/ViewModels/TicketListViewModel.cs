using System;
using System.Collections.ObjectModel;
using HelpDeskMobile.Models;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace HelpDeskMobile.ViewModels
{
	public class TicketListViewModel : ViewModelBase
    {
		public ObservableCollection<Ticket> Tickets { get; set; }

		public bool IsBusy { get; set; }

		public Command AddNewTicketCommand { get; set; }

		public Command RefreshTicketsCommand { get; set; }

		public TicketListViewModel(INavigation navigation) : base(navigation)
		{
			Tickets = new ObservableCollection<Ticket>();
			IsBusy = false;

			AddNewTicketCommand = new Command(x => AddNewTicket());
			RefreshTicketsCommand = new Command(async () => await RefreshTickets(true));


			//Tickets = new ObservableCollection<Ticket>();
			//Tickets.Add(
			//	new Ticket()
			//	{
			//		Id = "1",
			//		TicketId = "1000",
			//		Title = "User cannot login to the system",
			//		CreatedAt = new DateTime(2016, 11, 22, 6, 15, 45).ToString(),
   //                 Description = "The same thing that happens few months ago with my user in the main system",
   //                 Priority = "High",
			//		Username = "rguerra",
   //                 Status = "Open",
   //                 Area = "Customer",
   //                 Location = "Anchorage",
   //                 Category = "Meat",
   //                 Subcategory = "Poultry"
   //             });
			//Tickets.Add(
			//	new Ticket()
			//	{
			//		Id = "2",
			//		TicketId = "1001",
			//		Title = "Ticket test 2",
			//		CreatedAt = new DateTime(2016, 11, 24, 15, 41, 20).ToString(),
   //                 Description = "I have no idea what i need to put here, but I need to add something long",
			//		Priority = "Low",
			//		Username = "pperez",
   //                 Status = "Open",
   //                 Area = "Accounting",
   //                 Location = "Lincoln",
   //                 Category = "Beverages",
   //                 Subcategory = "Confections"
   //             }
			//);
		}

		void AddNewTicket()
		{
			throw new NotImplementedException();
		}

        async Task<bool> RefreshTickets(bool force = false)
		{
            if (IsBusy)
                return false;

            try
            {
                Tickets = new ObservableCollection<Ticket>(
                    await StoreManager.TicketStore.GetItemsAsync(force));
                    
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }

            return true;
        }
	}
}
