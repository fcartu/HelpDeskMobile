using HelpDeskMobile.DataStore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelpDeskMobile.ViewModels
{
    public class ViewModelBase
    {
        protected INavigation Navigation { get; }

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
                //TODO: Implement azure store.
            }
        }
    }
}
