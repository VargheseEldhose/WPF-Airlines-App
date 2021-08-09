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
    /// Interaction logic for FlightsWindow.xaml
    /// </summary>
    public partial class FlightsWindow : Window
    {
       



       
        public FlightsWindow()
        {

            InitializeComponent();
          

            var names = from flights in Data.FlightDET.Reverse()
                        select flights.DepartureCity;
            LBFlights.DataContext = names;

        }

        private void FltWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void FltWindow_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LBFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = LBFlights.SelectedIndex;
            var selectedFlight = from flight in Data.FlightDET
                                 where flight.FlightID == i
                                 select flight;

            foreach (var s in selectedFlight)
            {
                TBDeptCity.Text = s.DepartureCity;
                TBDestCity.Text = s.DestinationCity;
                TBDeptTime.Text = s.DepartureDate;
                TBFlightTime.Text = Convert.ToString(s.FlightTime);
                TBAirlineID.Text = Convert.ToString(s.AirlineID);
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ViewCustmenuM_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow p = new CustomerWindow();
            p.Title = "Customer";
            p.ShowDialog();
        }

        private void viewairmenu2_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            a.Title = "AirLines";
            a.ShowDialog();
        }

        private void viewflightsmenu4_Click(object sender, RoutedEventArgs e)
        {
            FlightsWindow f = new FlightsWindow();
            f.Title = "Flights";
            f.ShowDialog();
        }

        private void viewpassmenu4_Click(object sender, RoutedEventArgs e)
        {
            PassengersWindow p = new PassengersWindow();
            p.Title = "Passengers";
            p.ShowDialog();
        }

        private void BtnAddFlights_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                    {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {

                    var tempAir = from air in Data.AirList
                                  where Convert.ToInt32(TBAirlineID.Text) == air.AirlinesID
                                  select air;

                    if (tempAir.ToList().Count == 0)
                    {
                        MessageBox.Show("AirLineID you entered is not a valid foriegn key", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }





                    else
                    {
                        if ((TBDeptCity.Text == "") || TBDestCity.Text == "" || TBFlightTime.Text == "" || TBDeptTime.Text == "" || TBAirlineID.Text == "")
                        {
                            MessageBox.Show("No empty fields allowed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                        else
                        {
                            Data.FlightDET.Push(new Flights(Data.FlightDET.Count, Convert.ToInt32(TBAirlineID.Text), TBDeptCity.Text, TBDestCity.Text, TBDeptTime.Text,
                                Convert.ToDouble(TBFlightTime.Text)));


                            var cust = from details in Data.FlightDET
                                       select details.DepartureCity;
                            LBFlights.DataContext = cust;

                        }



                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnUpdateFlights_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int count = Data.FlightDET.Count;

                    Console.WriteLine(Data.AirList.Count);
                    var tempAir = from air in Data.AirList
                                  where Convert.ToInt32(TBAirlineID.Text) == air.AirlinesID
                                  select air;



                    if (tempAir.ToList().Count == 0)
                    {


                        MessageBox.Show("AirLineID you entered is not a valid foriegn key", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {


                        Flights f = new Flights(LBFlights.SelectedIndex, Convert.ToInt32(TBAirlineID.Text), TBDeptCity.Text, TBDestCity.Text, TBDeptTime.Text,
                            Convert.ToDouble(TBFlightTime.Text));


                        Data.FlightDET.ToArray()[LBFlights.SelectedIndex].AirlineID = Convert.ToInt32(TBAirlineID.Text);
                        Data.FlightDET.ToArray()[LBFlights.SelectedIndex].DepartureCity = TBDeptCity.Text;
                        Data.FlightDET.ToArray()[LBFlights.SelectedIndex].DestinationCity = TBDestCity.Text;
                        Data.FlightDET.ToArray()[LBFlights.SelectedIndex].DepartureDate = TBDeptTime.Text;

                        var cust = from details in Data.FlightDET
                                   select details.DepartureCity;
                        LBFlights.DataContext = cust;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Help1C_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void BtnDeleteFlights_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    List<Flights> temp = new List<Flights>();
                    int count = Data.FlightDET.Count;
                    for (int i = 0; i < count; i++)
                    {
                        temp.Add(Data.FlightDET.Pop());
                    }

                    temp.RemoveAt(LBFlights.SelectedIndex);
                    for (int i = 0; i < temp.Count; i++)
                    {
                        temp[i].FlightID = i;
                    }

                    for (int i = 0; i < temp.Count; i++)
                    {
                        Data.FlightDET.Push(temp[i]);
                    }

                    var cust = from details in Data.FlightDET.Reverse()
                               select details.DepartureCity;
                    LBFlights.DataContext = cust;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InsertMenuF_Click(object sender, RoutedEventArgs e)
        {
            BtnAddFlights_Click(sender, e);

        }

        private void DeleteMenuf_Click(object sender, RoutedEventArgs e)
        {
            BtnDeleteFlights_Click(sender, e);
        }

        private void Updatemenuf_Click(object sender, RoutedEventArgs e)
        {
            BtnUpdateFlights_Click(sender, e);
        }
    }
    
}
