using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_implementacion_DSAV.VistaModelo;
using MvvM_Implementacion_OGV.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvM_Implementacion_OGV.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new VMpage2(Navigation);
        }
    }
}
