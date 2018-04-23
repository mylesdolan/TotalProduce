using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Media;
using WCFInstant.ServiceReference1;
using CRUDBehavior;

namespace WCFInstant
{


    class Items2ViewModel
    {

        public RelayCommand YellowCommand { get; private set; }

        //    public int FSize { get; set; }
        int FSize = 30;

        public Items2ViewModel()
        {
           DatabaseEntities Entities = new DatabaseEntities(new Uri("http://localhost:62700/WcfDataService.svc/"));
            Messenger.Default.Send<DatabaseEntities>(Entities);
            YellowCommand = new RelayCommand(SendExecute);
            
        }

        private void SendExecute()
        {
            Messenger.Default.Send<int>(FSize);
        }


    }











}

