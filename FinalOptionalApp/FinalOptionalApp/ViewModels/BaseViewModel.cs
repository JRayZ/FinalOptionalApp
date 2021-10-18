using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Prism.Navigation;

namespace FinalOptionalApp.ViewModels
{
    public abstract class BaseViewModel:INotifyPropertyChanged
    {
        protected INavigationService NavigationService { get; }
        protected BaseViewModel (INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
