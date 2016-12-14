using HelpDeskMobile.DataStore.Abstractions;
using Xamarin.Forms;

namespace HelpDeskMobile.ViewModels
{
    public class ViewModelBase
    {
        protected INavigation Navigation { get; }

        protected IStoreManager StoreManager { get; } = DependencyService.Get<IStoreManager>();

        public ViewModelBase(INavigation navigation = null)
        {
            Navigation = navigation;
        }

        public static void Init(bool mock = true)
        {
            if (mock)
            {
                DependencyService.Register<ITicketStore, DataStore.Mock.TicketStore>();
            }
            else
            {
                DependencyService.Register<ITicketStore, DataStore.Azure.TicketStore>();
            }
        }
    }
}
