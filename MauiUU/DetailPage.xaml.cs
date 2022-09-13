using MauiUU.ViewModel;

namespace MauiUU;

public partial class DetailPage : ContentPage
{
	public DetailPage(DatailViewModel detailViewModel)
	{
		InitializeComponent();
		BindingContext = detailViewModel;

    }
}