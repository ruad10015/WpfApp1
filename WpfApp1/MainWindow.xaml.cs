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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //if (sender is Button btn)
            //{
            //    MessageBox.Show($"Hey i am {btn.Content}");
            //}

            //if (sender is Button btn)
            //{
            //    var result = MessageBox.Show("WPF", "Button Clicked", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            //    if(result == MessageBoxResult.OK)
            //    {
            //        MessageBox.Show("OK");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cancel");
            //    }
            //}
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            var x = e.GetPosition(sender as StackPanel).X;
            var y = e.GetPosition(sender as StackPanel).Y;
            btn1.Content = $"X : {x}  Y : {y}";
        }

        private void btn1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                //mystack.Background = Brushes.Red;
            }
            else if(e.RightButton==MouseButtonState.Pressed)
            {
               // mystack.Background = Brushes.Yellow;
            }
        }
    }
}
