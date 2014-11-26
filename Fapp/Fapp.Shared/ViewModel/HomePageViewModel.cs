using Fapp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fapp.ViewModel
{
    public class HomePageViewModel : ViewModelBase
    {
        public INavigationService _navigationService;

        public HomePageViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
            if (IsInDesignMode)
            {
                 //Code runs in Blend --> create design time data.
                List<Container> listeCont = new List<Container>();
                listeCont.Add(new Container(1,"frigo",new DateTime(2014,11,26),1));
                listeCont.Add(new Container(2, "congel", new DateTime(2014, 11, 25), 2));
            }
            else
            {
                // Code runs "for real"
            }
            
        }

    }
}
