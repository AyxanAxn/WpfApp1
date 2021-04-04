using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Btn.Content = "Hello world";
        }



        //private void Btn_Click(object sender, RoutedEventArgs e)
        //{
        //    var result = MessageBox.Show("Hello brat", "C# language", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        Btn.Content = "WTF?";
        //    }
        //    if (result == MessageBoxResult.No)
        //    {
        //        Btn.Content = "ala kisi adamsan...";
        //    }
        //}

        private void Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            


        }
    }
}
