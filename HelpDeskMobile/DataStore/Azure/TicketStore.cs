using HelpDeskMobile.DataStore.Abstractions;
using HelpDeskMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpDeskMobile.DataStore.Azure
{
    public class TicketStore : BaseStore<Ticket>, ITicketStore
    {
        public override string Identifier => "Ticket";

        public override async Task<IEnumerable<Ticket>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeStore().ConfigureAwait(false);
            if (forceRefresh)
                await PullLatestAsync().ConfigureAwait(false);

            var tickets = await Table.OrderBy(s => s.TicketId).ToListAsync().ConfigureAwait(false);

            return tickets;
        }
    }
}
