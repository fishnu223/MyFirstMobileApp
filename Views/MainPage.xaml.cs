using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
       InitializeComponent();
	   BindingContext = new MainViewModel();
	}
}