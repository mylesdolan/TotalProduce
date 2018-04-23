using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WCFInstant.ServiceReference1;
using GalaSoft.MvvmLight.Messaging;

namespace WCFInstant
{
    /// <summary>
    /// Interaction logic for Items2View.xaml
    /// </summary>
    public partial class Items2View : Window
    {
        public static readonly DependencyProperty EntitiesProperty =
          //   DependencyProperty.Register("Entities", typeof(DatabaseEntities), typeof(MainWindow), new UIPropertyMetadata(null));
         DependencyProperty.Register("Entities", typeof(DatabaseEntities), typeof(Items2View), new UIPropertyMetadata(null));
        public DatabaseEntities Entities
        {
            get { return (DatabaseEntities)GetValue(EntitiesProperty); }
            set { SetValue(EntitiesProperty, value); }
        }
        public Items2View()
        {
            Messenger.Default.Register<DatabaseEntities>(this, (action) => DbProp(action));

            // Entities = new DatabaseEntities(new Uri("http://localhost:62700/WcfDataService.svc/"));
            //DataContext = this;
          //  InitializeComponent();
           // helper.PropertiesList.Add("Id");
            //helper.PropertiesList.Add("Name");
            DataContext = new Items2ViewModel();
            InitializeComponent();
            helper.PropertiesList.Add("Id");
            helper.PropertiesList.Add("Name");
          


        }


        public void DbProp(DatabaseEntities x) {
            this.Entities = x;
            
        }


    }
}
