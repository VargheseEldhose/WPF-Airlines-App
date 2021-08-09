using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MidTerm
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            Data.addPassenger();
            Data.addAirlines();
            Data.addFlights();
            Data.addCustomer();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Quitoption_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPassengers_Click(object sender, RoutedEventArgs e)
        {
            PassengersWindow p = new PassengersWindow();
           
            p.Title = "Passenger";
            p.ShowDialog();
        }

        private void BtnAirlines_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            
            a.ShowDialog();
        }

        private void BtnFlights_Click(object sender, RoutedEventArgs e)
        {
            FlightsWindow f = new FlightsWindow();
           
            f.ShowDialog();
        }

        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow c = new CustomerWindow();
           
            c.ShowDialog();
        }

        private void HomeWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void HelpH_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }
}
