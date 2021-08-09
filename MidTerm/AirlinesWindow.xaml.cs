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
    /// Interaction logic for AirlinesWindow.xaml
    /// </summary>
    public partial class AirlinesWindow : Window
    {  
        
         

       

        public AirlinesWindow()
        {
            InitializeComponent();
           
            
            var names = from air in Data.AirList
                                        select air.Airplane;
            LBAirlines.DataContext = names;
        }

        private void AirlinesWindow1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LBAirlines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = LBAirlines.SelectedIndex;
            var selectedAirline = from al in Data.AirList
                                  where al.AirlinesID == i
                                  select al;

            foreach (var s in selectedAirline)
            {
                TBAirlineName.Text = s.Airplane;
                TBSeatsAvail.Text = Convert.ToString(s.SeatsAvailable);
                if(s.MealsAvailable=="Breakfast")
                {
                    BreakFast.IsChecked = true;
                }
                else if(s.MealsAvailable=="Lunch")
                {
                    Lunch.IsChecked = true;
                }
                else if(s.MealsAvailable=="Dinner")
                {
                    Dinner.IsChecked = true;
                }

                if(s.NameAirlines=="AirCanada")
                {
                    AirCanada.IsChecked = true;
                }
                else if(s.NameAirlines=="Jet")
                { Jet.IsChecked = true; }
                else
                {
                    AirIndia.IsChecked = true;
                }
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ViewCustM_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow p = new CustomerWindow();
            p.Title = "Customer";
            p.ShowDialog();
        }

        private void ViewAirmenu2_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            a.Title = "AirLines";
            a.ShowDialog();
        }

        private void viewflightsmenu3_Click(object sender, RoutedEventArgs e)
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

        private void BtnAddAirline_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if ((TBAirlineName.Text == "") || TBSeatsAvail.Text == "" || ((Convert.ToBoolean(AirCanada.IsChecked) == false) && (Convert.ToBoolean(AirIndia.IsChecked) == false) &&
                         (Convert.ToBoolean(Jet.IsChecked) == false)) || ((Convert.ToBoolean(BreakFast.IsChecked) == false) && (Convert.ToBoolean(Lunch.IsChecked) == false) &&
                         (Convert.ToBoolean(Dinner.IsChecked) == false)))
                    {
                        MessageBox.Show("No empty fields allowed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        if (AirCanada.IsChecked == true && BreakFast.IsChecked == true)
                        {

                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast"));


                        }
                        else if (AirIndia.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner"));

                        }
                        else if (AirCanada.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch"));
                        }
                        else if (Jet.IsChecked == true && BreakFast.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast"));

                        }
                        else if (Jet.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch"));

                        }
                        else if (Jet.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner"));

                        }
                        else if (AirIndia.IsChecked == true && BreakFast.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast"));

                        }
                        else if (AirIndia.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch"));

                        }
                        else if (AirIndia.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList.Add(new Airlines(Data.AirList.Count, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner"));

                        }


                    }
                    var names = from air in Data.AirList
                                select air.Airplane;
                    LBAirlines.DataContext = names;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void HelpAboutA_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void Insertfrommen_Click(object sender, RoutedEventArgs e)
        {
            BtnAddAirline_Click(sender, e);

        }

        private void BtnUpdateAirlines_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if ((TBAirlineName.Text == "") || TBSeatsAvail.Text == "" || ((Convert.ToBoolean(AirCanada.IsChecked) == false) && (Convert.ToBoolean(AirIndia.IsChecked) == false) &&
                     (Convert.ToBoolean(Jet.IsChecked) == false)) || ((Convert.ToBoolean(BreakFast.IsChecked) == false) && (Convert.ToBoolean(Lunch.IsChecked) == false) &&
                     (Convert.ToBoolean(Dinner.IsChecked) == false)))
                    {
                        MessageBox.Show("No empty fields allowed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        if (AirCanada.IsChecked == true && BreakFast.IsChecked == true)
                        {

                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast");


                        }
                        else if (AirIndia.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner");

                        }
                        else if (AirCanada.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch");
                        }
                        else if (Jet.IsChecked == true && BreakFast.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast");

                        }
                        else if (Jet.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch");

                        }
                        else if (Jet.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "Jet", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner");

                        }
                        else if (AirIndia.IsChecked == true && BreakFast.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Breakfast");

                        }
                        else if (AirIndia.IsChecked == true && Lunch.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Lunch");

                        }
                        else if (AirIndia.IsChecked == true && Dinner.IsChecked == true)
                        {
                            Data.AirList[LBAirlines.SelectedIndex] = new Airlines(LBAirlines.SelectedIndex, "AirCanada", TBAirlineName.Text, Convert.ToInt32(TBSeatsAvail.Text), "Dinner");

                        }


                    }
                    var names = from air in Data.AirList
                                select air.Airplane;
                    LBAirlines.DataContext = names;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdfrommenuA_Click(object sender, RoutedEventArgs e)
        {
            BtnUpdateAirlines_Click(sender, e);
        }

        private void DltfromMenuA_Click(object sender, RoutedEventArgs e)
        {
            BtnDeleteAirlines_Click(sender, e);
        }

        private void BtnDeleteAirlines_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Data.AirList.RemoveAt(LBAirlines.SelectedIndex);
                    for (int i = 0; i < Data.AirList.Count; i++)
                    {
                        Data.AirList[i].AirlinesID = i;
                    }

                    var air = from temp in Data.AirList
                              select temp.Airplane;
                    LBAirlines.DataContext = air;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
