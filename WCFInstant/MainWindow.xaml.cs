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
using GalaSoft.MvvmLight.Messaging;

namespace WCFInstant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            Messenger.Default.Register<NavigateMessage>(this, (action) => ShowUserControl(action));
            Messenger.Default.Register<int>(this, (action) => ReceiveMessageChangeButton2Red(action));
            this.DataContext = new MainWindowViewModel();
         //   ReceiveMessageChangeButton2Red(20);
        }

        private void ShowUserControl(NavigateMessage nm)
        {
            // EditFrame.Content = nm.View;
            nm.View.ShowDialog();
            

        }

        private void ReceiveMessageChangeButton2Red(int fsize)
        {
            hello.FontSize = fsize;
            
        }

    }
}
