﻿using HelpDeskMobile.Pages;
using HelpDeskMobile.ViewModels;
using Xamarin.Forms;

namespace HelpDeskMobile
{
	public static class ViewModelLocator
	{
		static TicketListViewModel ticketVM;

		public static TicketListViewModel TicketListVM
		=> ticketVM ?? (ticketVM = new TicketListViewModel(true));
	}

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// The root page of your application
			MainPage = new NavigationPage(new TicketsPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
