using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace WCFInstant
{
    public class ViewVM
    {
        public string ViewDisplay { get; set; }
        public Type ViewType { get; set; }
        public Type ViewModelType { get; set; }
        //public UserControl View { get; set; }

        public System.Windows.Window View { get; set; }
        public RelayCommand Navigate { get; set; }
        public ViewVM()
        {
            Navigate = new RelayCommand(NavigateExecute);
        }
        public void NavigateExecute()
        {
            //if(View == null && ViewType != null)
            if (ViewType != null)
            {
                //ViewX = (UserControl)Activator.CreateInstance(ViewType);
                View = (System.Windows.Window)Activator.CreateInstance(ViewType);
                //View = (UserControl)Activator.CreateInstance(ViewType);
            }
            var msg = new NavigateMessage { View = View, ViewModelType = ViewModelType, ViewType = ViewType };
            Messenger.Default.Send<NavigateMessage>(msg);
        }
    }
}

