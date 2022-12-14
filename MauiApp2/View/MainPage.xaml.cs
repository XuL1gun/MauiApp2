using MauiApp2.ViewModel;

namespace MauiApp2.View;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ShoppingListViewModel();
    }
}

