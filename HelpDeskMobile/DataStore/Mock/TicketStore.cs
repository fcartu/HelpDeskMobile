using HelpDeskMobile.DataStore.Abstractions;
using HelpDeskMobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpDeskMobile.DataStore.Mock
{
    public class TicketStore : BaseStore<Ticket>, ITicketStore
    {
        List<Ticket> tickets;

        #region IBaseStore implementation

        bool initialized = false;

        public async override Task InitializeStore()
        {
            if (initialized)
                return;

            initialized = true;

            tickets = new List<Ticket>();

            for (int i = 0; i < titlesShort.Length; i++)
            {
                tickets.Add(new Ticket
                {
                    Id = Guid.NewGuid().ToString(),
                    TicketId = i.ToString(),
                    Title = titlesShort[i],
                    Description = descriptions[i],
                    CreatedAt = new DateTime(2016, 11, i).ToString(),
                    Area = areas[i],
                    Priority = priorities[i],
                    Status = "Open",
                    Deleted = false,
                    Username = users[i],
                    Category = categories[i],
                    Subcategory = categories[i],
                    Location =""                    
                });

                
            }
        }

        string[] descriptions = new[] {
            "Create stunning apps with the Xamarin Designer for iOS",
            "Everyone can create beautiful apps with material design",
            "Dispelling design myths and making apps better",
            "3 Platforms: 1 codebase—your first Xamarin.Forms app",
            "Mastering XAML in Xamarin.Forms",
            "NuGet your code to all the platforms with portable class libraries",
            "A new world of possibilities for contextual awareness with iBeacons",
            "Wearables and IoT: Taking C# with you everywhere",
            "Create the next great mobile app in a weekend",
            "Best practices for effective iOS memory management",
            "Navigation design patterns for iOS and Android",
            "Is your app secure?",
            "Introduction to Xamarin.Insights",
            "Cross platform unit testing with xUnit",
            "Test automation in practice with Xamarin Test Cloud at MixRadio",
            "Why you should be building better mobile apps with reactive programming",
            "Create your own sci-fi with mobile augmented reality",
            "Addressing the OWASP mobile security threats using Xamarin"
        };

        string[] titlesShort = new[] {
            "Stunning iOS Apps",
            "Material Design",
            "Making apps better",
            "3 Platforms: 1 codebase",
            "Mastering XAML",
            "NuGet your code",
            "iBeacons",
            "Wearables and IoT",
            "The next great app",
            "iOS Best Practices",
            "Navigation patterns",
            "Is your app secure?",
            "Xamarin.Insights",
            "xUnit",
            "Test Cloud at MixRadio",
            "Reactive programming",
            "Augmented reality",
            "OWASP mobile security"
        };

        string[] priorities = new[] 
        {
            "Medium",
            "High",
            "Low",
            "High",
            "Medium",
            "Low",
            "Low",
            "Low",
            "Medium",
            "High",
            "High",
            "Medium",
            "High",
            "Low",
            "Low",
            "High",
            "High",
            "Medium"
        };

        string[] areas = new[]
        {
           "Accounting",
           "Web",
           "Service",
           "International Customer",
           "Customer",
           "Web",
           "Accounting",
           "Web",
           "Accounting",
           "Marketing",
           "Prepaid Customer",
           "Accounting",
           "Web",
           "Marketing",
           "Technical",
           "Accounting",
           "Accounting",
           "Sales"
        };

        string[] users = new[]
        {
            "Arnold Valdez",
            "Elisa Hancock",
            "Brooke Good",
            "Cari Galloway",
            "Colleen Hayes",
            "Jill Bowen",
            "Gilberto Ward",
            "Amelia Hunter",
            "Oliver Jenkins",
            "Jamison Dean",
            "Brad Wood",
            "Rosa Reilly",
            "Guy Sloan",
            "Kathryn Conrad",
            "Jerry Graham",
            "Jami Middleton",
            "Brandi Griffin",
            "Shana Mc Knight"
        };

        string[] categories = new[]
        {
            "Meat",
            "Poultry",
            "Dairy",
            "Poultry",
            "Confections",
            "Meat",
            "Snails",
            "Snails",
            "Beverages",
            "Grain",
            "Snails",
            "Poultry",
            "Shell fish",
            "Beverages",
            "Seafood",
            "Cereals",
            "Cereals",
            "Grain"
        };

        string[] location = new[]
        {
            "Lincoln",
            "Arlington",
            "Newark",
            "Sacramento",
            "Los Angeles",
            "San Diego",
            "Anchorage",
            "Honolulu",
            "Fresno",
            "Raleigh",
            "New Orleans",
            "Louisville",
            "Albuquerque",
            "Colorado",
            "Jackson",
            "Santa Ana",
            "Colorado",
            "Fresno"
        };

        #endregion
    }
}
