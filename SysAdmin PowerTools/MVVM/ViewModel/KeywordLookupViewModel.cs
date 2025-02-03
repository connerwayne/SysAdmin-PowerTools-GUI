using SysAdmin_PowerTools.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAdmin_PowerTools.MVVM.ViewModel
{
    class KeywordLookupViewModel : ObservableObject
    {
        private string _keyword;

        public string Keyword
        {
            get { return _keyword; }
            set
            {
                _keyword = value;
                OnPropertyChanged();
            }
        }

        public KeywordLookupViewModel()
        {
            // Populate with initial data
            Keyword = "Initial Keyword";
        }
    }
}

