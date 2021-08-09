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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window 
    {
       // public static Queue<Customer> customerDetails = new Queue<Customer>();
        public CustomerWindow()
        {
            InitializeComponent();
            
           
            var names = from cust in Data.Queu
                        select cust.Cust_Name;
            LBCustomers.DataContext = names;
        }

        private void CustWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LBCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = LBCustomers.SelectedIndex;
            var selectedCust = from cust in Data.Queu
                               where cust.Customer_ID == i
                               select cust;

            foreach(var s in selectedCust)
            {
                TBCustName.Text = s.Cust_Name;
                TBemailCust.Text = s.Cust_email;
                TBaddressCust.Text = s.Cust_Address;
                TBPhoneCust.Text = s.Cust_Phone;
            }
        }

        private void BtnAddCust_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if ((TBCustName.Text == "") || TBaddressCust.Text == "" || TBemailCust.Text == "" || TBPhoneCust.Text == "")
                    {
                        MessageBox.Show("No empty fields allowed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else
                    {
                        Data.Queu.Enqueue(new Customer(Data.Queu.Count, TBCustName.Text, TBaddressCust.Text, TBemailCust.Text, TBPhoneCust.Text));

                        var cust = from details in Data.Queu
                                   select details.Cust_Name;
                        LBCustomers.DataContext = cust;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnUpdateCust_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Customer c = new Customer(LBCustomers.SelectedIndex, TBCustName.Text, TBaddressCust.Text, TBemailCust.Text, TBPhoneCust.Text);
                    List<Customer> l = new List<Customer>();
                    int tempCount = Data.Queu.Count;
                    for (int i = 0; i < tempCount; i++)
                    {
                        l.Add(Data.Queu.Dequeue());
                    }

                    l[LBCustomers.SelectedIndex] = c;

                    for (int i = 0; i < tempCount; i++)
                    {
                        Data.Queu.Enqueue(l[i]);
                    }

                    var cust = from details in Data.Queu
                               select details.Cust_Name;
                    LBCustomers.DataContext = cust;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnDeleteCust_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginWindow.IS)
                {
                    MessageBox.Show("You are not a super user", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    List<Customer> l = new List<Customer>();
                    int tempCount = Data.Queu.Count;
                    for (int i = 0; i < tempCount; i++)
                    {
                        l.Add(Data.Queu.Dequeue());


                    }
                    l.RemoveAt(LBCustomers.SelectedIndex);
                    for (int i = 0; i < l.Count; i++)
                    {
                        l[i].Customer_ID = i;
                        Data.Queu.Enqueue(l[i]);
                    }



                    var cust = from details in Data.Queu
                               select details.Cust_Name;
                    LBCustomers.DataContext = cust;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InsertCustFromMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnAddCust_Click(sender, e);
        }

        private void UpdateCustFromMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnUpdateCust_Click(sender, e);


        }

        private void DeleteCustFromMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnDeleteCust_Click(sender,e);
        }

        private void view_custMenu_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow p = new CustomerWindow();
            p.Title = "Customer";
            p.ShowDialog();
          
        }

        private void view_airlinM_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            a.Title = "AirLines";
            a.ShowDialog();
        }

        private void view_flightM_Click(object sender, RoutedEventArgs e)
        {
            FlightsWindow f = new FlightsWindow();
            f.Title = "Flights";
            f.ShowDialog();
        }

        private void view_passM_Click(object sender, RoutedEventArgs e)
        {
            PassengersWindow p = new PassengersWindow();
            p.Title = "Passengers";
            p.ShowDialog();
        }

        private void HelpC_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }
}
