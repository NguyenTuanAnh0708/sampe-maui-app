



using sample_app_mvvm.ViewModels;

namespace sample_app_mvvm;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


}

