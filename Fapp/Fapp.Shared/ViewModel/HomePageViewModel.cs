using Fapp.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Fapp.ViewModel
{
    public class HomePageViewModel : ViewModelBase
    {
        //public INavigationService _navigationService;
        public ObservableCollection<Container> Containers { get; private set; }

        public HomePageViewModel(){}

        [PreferredConstructor]
        public HomePageViewModel(IListContainerService service)
        {
            Containers = new ObservableCollection<Container>();
            if (IsInDesignMode)
            {
                 //Code runs in Blend --> create design time data.
                
            }
            else
            {
                // Code runs "for real"
                InitializeAsync(service);
            }
            
        }

        private async Task InitializeAsync(IListContainerService service)
        {
            Containers.Clear();
            var containers = await service.GetItemsAsync();
            foreach (var container in containers)
                Containers.Add(container);
        }

    }
}
