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

namespace MidTerm
{
    /// <summary>
    /// Interaction logic for PassengersWindow.xaml
    /// </summary>
    public partial class PassengersWindow : Window
    {



        public PassengersWindow()
        {
            InitializeComponent();

            var cust = from details in Data.Pass
                       select details.CustomerID_Pasenger;
            LBPassengers.DataContext = cust;

        }
        
        private void PassWind_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void LBPassengers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = LBPassengers.SelectedIndex;
            var selectedCust = from cust in Data.Pass
                               where cust.PassengerID == i
                               select cust;

            foreach (var s in selectedCust)
            {
                TBCustID.Text = s.CustomerID_Pasenger.ToString();
                TBFlightID.Text = s.FlightID_passenger.ToString();

            }
        }


        private void ViewCustMenu3_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow p = new CustomerWindow();
            p.Title = "Customer";
            p.ShowDialog();
        }

        private void ViewAirLineMenu2_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            a.Title = "AirLines";
            a.ShowDialog();
        }

        private void ViewFlightMenu3_Click(object sender, RoutedEventArgs e)
        {
            FlightsWindow f = new FlightsWindow();
            f.Title = "Flights";
            f.ShowDialog();
        }

        private void ViewPassmenu4_Click(object sender, RoutedEventArgs e)
        {
            PassengersWindow p = new PassengersWindow();
            p.Title = "Passengers";
            p.ShowDialog();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Passenger p = new Passenger(Data.Pass.Count, Convert.ToInt32(TBCustID.Text), Convert.ToInt32(TBFlightID.Text));

                    var temp = from ptemp in Data.Queu
                               where p.CustomerID_Pasenger == ptemp.Customer_ID
                               select ptemp;
                    var temp2 = from ptemp in Data.FlightDET
                                where p.FlightID_passenger == ptemp.FlightID
                                select ptemp;
                    if (temp.ToArray().Length == 0 || temp2.ToArray().Length == 0)
                    {
                        MessageBox.Show("You entered invalid foriegn key(Values for Flight and customer ID)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                        Data.Pass.Add(p);

                    var cust = from details in Data.Pass
                               select details.CustomerID_Pasenger;
                    LBPassengers.DataContext = cust;
                }
            }catch(Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnDlt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Data.Pass.RemoveAt(LBPassengers.SelectedIndex);


                    for (int i = 0; i < Data.Pass.Count; i++)
                    {
                        Data.Pass[i].PassengerID = i;
                    }

                    var cust = from details in Data.Pass
                               select details.CustomerID_Pasenger;
                    LBPassengers.DataContext = cust;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void HelpP_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void InsertPassM_Click(object sender, RoutedEventArgs e)
        {
            BtnAdd_Click(sender, e);
        }

        private void DeletePassM_Click(object sender, RoutedEventArgs e)
        {
            BtnDlt_Click(sender, e);
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Passenger p = new Passenger(LBPassengers.SelectedIndex, Convert.ToInt32(TBCustID.Text), Convert.ToInt32(TBFlightID.Text));
                    var temp = from ptemp in Data.Queu
                               where p.CustomerID_Pasenger == ptemp.Customer_ID
                               select ptemp;
                    var temp2 = from ptemp in Data.FlightDET
                                where p.FlightID_passenger == ptemp.FlightID
                                select ptemp;
                    if (temp.ToArray().Length == 0 || temp2.ToArray().Length == 0)
                    {
                        MessageBox.Show("You entered invalid foriegn key(Values for Flight and customer ID)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {

                        Data.Pass[LBPassengers.SelectedIndex] = p;

                    }

                    var cust = from details in Data.Pass
                               select details.CustomerID_Pasenger;
                    LBPassengers.DataContext = cust;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateM_Click(object sender, RoutedEventArgs e)
        {
            BtnUpdate_Click(sender, e);
        }

    }
   

    }

