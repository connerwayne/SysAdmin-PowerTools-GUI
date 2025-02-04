
// Page Instructions to add new items to the project:

// 1. Add RelayCommand below for the item you want to activate. 
// 2. Add a new ViewModel object for the item you want to activate.
// 3. Instantiate both the RelayCommand and ViewModel objects in the MainViewModel constructor.
// 3. Add a new DataTemplate in the App.xaml file.
// 4. 


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
        // RelayCommand is a custom class that inherits from ICommand and is used to bind commands to buttons in WPF applications
        public RelayCommand HomeViewCommand { get; set; }  // a RelayCommand for the HomeView  
        public RelayCommand TechDocViewCommand { get; set; } // a RelayCommand for the TechDocView
        public RelayCommand ServerToolsViewCommand { get; set; } // a RelayCommand for the ServerToolsView
        public RelayCommand KeywordLookupViewCommand { get; set; }
        public RelayCommand AccessReviewViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; } // a HomeViewModel object
        public TechDocViewModel TechDocVM { get; set; } // a TechDocViewModel object
        public ServerToolsViewModel ServerToolsVM { get; set; } // a ServerToolsViewModel object
        public KeywordLookupViewModel KeywordLookupVM { get; set; }
        public AccessReviewViewModel AccessReviewVM { get; set; } 


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
            // Instantiate the ViewModel objects --- this makes the views available to the MainViewModel when called
            HomeVM = new HomeViewModel();
            TechDocVM = new TechDocViewModel();
            ServerToolsVM = new ServerToolsViewModel();
            KeywordLookupVM = new KeywordLookupViewModel();
            AccessReviewVM = new AccessReviewViewModel();
            CurrentView = HomeVM;


            // Instantiate the RelayCommand objects --- this makes the views available to the MainViewModel when called
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            TechDocViewCommand = new RelayCommand(o =>
            {
                CurrentView = TechDocVM;
            });
            ServerToolsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ServerToolsVM;
            });
            KeywordLookupViewCommand = new RelayCommand(o =>
            {
                CurrentView = KeywordLookupVM;
            });
            AccessReviewViewCommand = new RelayCommand(o =>
            {
                CurrentView = AccessReviewVM;
            });

        }
    }
}


