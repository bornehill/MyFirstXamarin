using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.ViewModel
{
    class DataVM
    {
        public string Title { get; set; }
        public string Name { get; set; }

        public DataVM()
        {
            Title = "Job";
            Name = "Development";
        }
    }
}
