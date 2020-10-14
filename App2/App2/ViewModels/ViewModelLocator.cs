using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModels
{
    class ViewModelLocator
    {

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();

        }
        public MainViewModel MainView => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}
