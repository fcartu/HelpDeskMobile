using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace HelpDeskMobile.Models
{
	public class Ticket
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "ticketId")]
		public string TicketId { get; set; }

		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "user")]
		public string Username { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "area")]
		public string Area { get; set; }

		[JsonProperty(PropertyName = "priority")]
		public string Priority { get; set; }

		[JsonProperty(PropertyName = "category")]
		public string Category { get; set; }

		[JsonProperty(PropertyName = "subcategory")]
		public string Subcategory { get; set; }

		[Deleted]
		public bool Deleted { get; set; }

		[CreatedAt]
		public string CreatedAt { get; set; }

		public DateTime CreatedAtDate
		{
			get
			{
				DateTime created;
				DateTime.TryParse(CreatedAt, out created);
				return created;
			}
		}

		[UpdatedAt]
		public string UpdatedAt { get; set; }

		[Version]
		public string Version { get; set; }
	}
}
