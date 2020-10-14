using App2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class MainPage : ContentPage
    {
        MainViewModel viewModel => (App.Current.Resources["Locator"] as ViewModelLocator).MainView;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;

        }
    }
}
