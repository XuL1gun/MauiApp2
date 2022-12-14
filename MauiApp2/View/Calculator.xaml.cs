using MauiApp2.ViewModel;

namespace MauiApp2.View;

public partial class Calculator : ContentPage
{
    public Calculator()
    {
        InitializeComponent();
        BindingContext = new CalculatorViewModel();
    }
}