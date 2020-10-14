using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string someText = "fefdge";

        public string SomeText
        {
            get { return someText; }
            set { Set(ref someText, value); }
        }

        public MainViewModel()
        {

        }

        private ICommand goPageBack;
        //public ICommand PageBack
        //{
        //    get
        //    {
        //        return goPageBack ?? (goPageBack = new RelayCommand<object>(
        //                  x => { GoPageBack(x); }));
        //    }
        //}
        //public void GoPageBack(object x)
        //{
        //    ((Button)x).Text = "yep";
        //    SomeText = "fdfdffsdd"; 
        //}
        public ICommand PageBack
        {
            get
            {
                return goPageBack ?? (goPageBack = new RelayCommand<object>(
                          x => { GoPageBack(); }));
            }
        }
        public void GoPageBack()
        {
            SomeText = "fdfdffsdd";
        }
    }
}
