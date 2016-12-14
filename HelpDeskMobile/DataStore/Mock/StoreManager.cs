using System;
using System.Threading.Tasks;
using HelpDeskMobile.DataStore.Abstractions;
using Xamarin.Forms;

namespace HelpDeskMobile.DataStore.Mock
{
    public class StoreManager : IStoreManager
    {
        #region IStoreManager implementation

        public Task<bool> SyncAllAsync(bool syncUserSpecific)
        {
            return Task.FromResult(true);
        }

        public bool IsInitialized { get { return true; } }
        public Task InitializeAsync()
        {
            return Task.FromResult(true);
        }

        public Task DropEverythingAsync()
        {
            return Task.FromResult(true);
        }

        ITicketStore ticketStore;
        public ITicketStore TicketStore => ticketStore ?? (ticketStore = DependencyService.Get<ITicketStore>());

        #endregion
    }
}
