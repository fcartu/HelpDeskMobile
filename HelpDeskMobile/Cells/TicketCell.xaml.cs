
using Xamarin.Forms;

namespace HelpDeskMobile.Cells
{
	public class TicketCell : ViewCell
	{
		public TicketCell()
		{
			Height = 120;
			View = new TicketCellView();
		}
	}

	public partial class TicketCellView : ContentView
	{
		public TicketCellView()
		{
			InitializeComponent();
		}
	}
}
