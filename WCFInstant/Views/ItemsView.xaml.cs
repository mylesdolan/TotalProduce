﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WCFInstant.ServiceReference1;

namespace WCFInstant {
    public partial class ItemsView: Window {
        public static readonly DependencyProperty EntitiesProperty =
            DependencyProperty.Register("Entities", typeof(DatabaseEntities), typeof(ItemsView), new UIPropertyMetadata(null));
        public DatabaseEntities Entities {
            get { return (DatabaseEntities)GetValue(EntitiesProperty); }
            set { SetValue(EntitiesProperty, value); }
        }
        public ItemsView() {
            Entities = new DatabaseEntities(new Uri("http://localhost:62700/WcfDataService.svc/"));
            DataContext = this;
            InitializeComponent();
            helper.PropertiesList.Add("Id");
            helper.PropertiesList.Add("Name");
        }
    }
}
