using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstXamarin.ViewModel
{
    class MessageVM
    {
        public ICommand ButtonClickedCommand { get; set; }

        public MessageVM()
        {
            ButtonClickedCommand = new Command(HandleButtonClick);
        }

        private void HandleButtonClick()
        {
            MessagingCenter.Send<MessageVM>(this, "ButtonClicked");
        }
    }

}
