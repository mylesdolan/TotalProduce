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
                new ViewVM{ ViewDisplay="Students", ViewType = typeof(Items2View), ViewModelType = typeof(Items2ViewModel)},
              new ViewVM{ ViewDisplay="Grades", ViewType = typeof(ItemsView), ViewModelType = typeof(ItemViewModel)},

            };

            Views = views;
            RaisePropertyChanged("Views");
          //  views[0].NavigateExecute();
        }

    }
}
