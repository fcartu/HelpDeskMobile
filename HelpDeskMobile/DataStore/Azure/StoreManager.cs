using HelpDeskMobile.DataStore.Abstractions;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using HelpDeskMobile.Models;

namespace HelpDeskMobile.DataStore.Azure
{
    public class StoreManager : IStoreManager
    {
        public static MobileServiceClient MobileService { get; set; }

        /// <summary>
        /// Syncs all tables.
        /// </summary>
        /// <returns>The all async.</returns>
        public async Task<bool> SyncAllAsync(bool syncUserSpecific)
        {
            if (!IsInitialized)
                await InitializeAsync();

            var taskList = new List<Task<bool>>();
            taskList.Add(TicketStore.SyncAsync());

            var successes = await Task.WhenAll(taskList).ConfigureAwait(false);
            return successes.Any(x => !x);//if any were a failure.
        }

        public Task DropEverythingAsync()
        {
            TicketStore.DropTable();

            IsInitialized = false;
            return Task.FromResult(true);
        }

        public bool IsInitialized { get; private set; }

        #region IStoreManager implementation
        object locker = new object();
        public async Task InitializeAsync()
        {
            MobileServiceSQLiteStore store;
            lock (locker)
            {
                if (IsInitialized)
                    return;

                IsInitialized = true;
                var dbId = 1; // TODO: Implement a real settings based on XamarinEvolve App.
                var path = $"syncstore{dbId}.db";
                MobileService = new MobileServiceClient(Constants.ApplicationURL);
                store = new MobileServiceSQLiteStore(path);
                store.DefineTable<Ticket>();
            }

            await MobileService.SyncContext.InitializeAsync(store, 
                new MobileServiceSyncHandler()).ConfigureAwait(false);
        }

        ITicketStore ticketStore;
        public ITicketStore TicketStore => ticketStore ?? (ticketStore = DependencyService.Get<ITicketStore>());

        #endregion        
    }
}
