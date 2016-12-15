using System;
using System.Collections.ObjectModel;
using HelpDeskMobile.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;

namespace HelpDeskMobile.ViewModels
{
	public class TicketListViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Ticket> Tickets { get; } = new ObservableRangeCollection<Ticket>();

		public Command AddNewTicketCommand { get; set; }

        ICommand refreshTicketsCommand;
        public ICommand RefreshTicketsCommand =>
            refreshTicketsCommand ?? (refreshTicketsCommand = new Command(async () => await RefreshTickets(true)));


        public TicketListViewModel(INavigation navigation) : base(navigation)
		{
			AddNewTicketCommand = new Command(x => AddNewTicket());
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
                IsBusy = true;

                Tickets.ReplaceRange(
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
