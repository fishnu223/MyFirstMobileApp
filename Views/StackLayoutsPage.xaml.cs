using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class StackLayoutsPage : ContentPage
{
	public StackLayoutsPage()
	{
		InitializeComponent();
		BindingContext = new StackLayoutViewModel();
	}
}