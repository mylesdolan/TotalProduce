using System.Collections.ObjectModel;





namespace WCFInstant
{
    class MainWindowViewModel : NotifyUIBase
    {
        public ObservableCollection<ViewVM> Views { get; set; }


        public MainWindowViewModel()
        {
            ObservableCollection<ViewVM> views = new ObservableCollection<ViewVM>
            {
             
              new ViewVM{ ViewDisplay="table1", ViewType = typeof(ItemsView), ViewModelType = typeof(ItemViewModel)},
 new ViewVM{ ViewDisplay="table2", ViewType = typeof(Items2View), ViewModelType = typeof(Items2ViewModel)},
            };

            Views = views;
            RaisePropertyChanged("Views");
          //  views[0].NavigateExecute();
        }

    }
}
