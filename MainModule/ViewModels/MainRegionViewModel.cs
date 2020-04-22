using SharedModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainModule.ViewModels
{
    public class MainRegionViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainRegionViewModel()
        {
            Title = "Hello World";
        }
    }
}
