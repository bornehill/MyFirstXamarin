using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MyFirstXamarin.ViewModel
{
    class SliceVM : INotifyPropertyChanged
    {
        private string labelText = "Hi!";

        public string LabelText
        {
            get { return labelText; }
            set {
                labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand
        {
            get { return changeTextCommand ?? (changeTextCommand = new Command(
                    () =>
                    {
                        LabelText = "Good Bye";
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
