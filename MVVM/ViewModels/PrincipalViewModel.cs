using System;
using Sensores.MVVM.Models;
using Sensores.MVVM.ViewModels;
using Sensores.MVVM.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;

namespace Sensores.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PrincipalViewModel
    {
        private ContentView detallesView;
        public ContentView DetallesView
        {
            get => detallesView;
            set
            {
                if (detallesView != value)
                {
                    detallesView = value;
                }
            }
        }

        public ICommand CamaraCommand { get; }
        public ICommand MovimientoCommand { get; }

        public PrincipalViewModel()
        {
            CamaraCommand = new Command(Camara);
            MovimientoCommand = new Command(Movimiento);

            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Movimiento();
            });
        }

        private void Camara()
        {
            DetallesView = new CamaraView();
        }

        private void Movimiento()
        {
            DetallesView = new MovimientoView();
        }
    }
}
