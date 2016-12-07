using System.Threading.Tasks;

namespace HelpDeskMobile.DataStore.Abstractions
{
    public interface IStoreManager
    {
        bool IsInitialized { get; }

        Task InitializeAsync();

        ITicketStore TicketStore { get; }

        Task<bool> SyncAllAsync(bool syncUserSpecific);

        Task DropEverythingAsync();
    }
}
