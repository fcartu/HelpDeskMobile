using HelpDeskMobile.DataStore.Abstractions;
using MvvmHelpers;
using Xamarin.Forms;

namespace HelpDeskMobile.ViewModels
{
    public class ViewModelBase : BaseViewModel
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
                DependencyService.Register<IStoreManager, DataStore.Mock.StoreManager>();
            }
            else
            {
                DependencyService.Register<ITicketStore, DataStore.Azure.TicketStore>();
                DependencyService.Register<IStoreManager, DataStore.Azure.StoreManager>();
            }
        }
    }
}
