using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvM_Implementacion_OGV.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvM_Implementacion_OGV.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMpagina1(Navigation);
        }
    }
}
