using Sensores.MVVM.ViewModels;

namespace Sensores.MVVM.Views;

public partial class MovimientoView : ContentView
{
    public MovimientoView()
    {
        InitializeComponent();
        BindingContext = new MovimientoViewModel();
    }
}