using SysAdmin_PowerTools.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAdmin_PowerTools.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TechDocViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public TechDocViewModel TechDocVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TechDocVM = new TechDocViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            TechDocViewCommand = new RelayCommand(o =>
            {
                CurrentView = TechDocVM;
            });
        }
    }
}


