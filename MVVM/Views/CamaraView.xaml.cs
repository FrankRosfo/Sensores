using Sensores.MVVM.Models;
using Sensores.MVVM.ViewModels;

namespace Sensores.MVVM.Views;

public partial class CamaraView : ContentView
{
	public CamaraView()
    {
		InitializeComponent();
        BindingContext = new CamaraViewModel();
    }
}