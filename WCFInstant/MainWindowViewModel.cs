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
                new ViewVM{ ViewDisplay="Items first table", ViewType = typeof(ItemsView), ViewModelType = typeof(ItemViewModel)},

                new ViewVM{ ViewDisplay="Items2 second table", ViewType = typeof(Items2View), ViewModelType = typeof(Items2ViewModel)},
              
            };

            Views = views;
            RaisePropertyChanged("Views");
          //  views[0].NavigateExecute();
        }

    }
}
