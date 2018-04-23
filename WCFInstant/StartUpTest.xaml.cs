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

namespace WCFInstant
{
    /// <summary>
    /// Interaction logic for StartUpTest.xaml
    /// </summary>
    public partial class StartUpTest : Window
    {
        public StartUpTest()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow iv = new MainWindow();
            iv.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
             Items2View i2v = new Items2View();
                i2v.ShowDialog();
        }


    }
}
