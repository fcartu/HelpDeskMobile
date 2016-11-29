﻿using System;
using HelpDeskMobile.Pages;
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

	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new TicketListPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

