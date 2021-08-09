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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private static bool isSup;

        public static bool IS
        {
           get{ return isSup; }
            set { isSup = value; }
        }
        public LoginWindow()
        {
            InitializeComponent();
            Data.addLogins();
         
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
           
                if (Data.LOGIN.ContainsKey(TbUser.Text)&& Data.LOGIN[TbUser.Text].Password== PBpassword.Password)

            {
                if (Data.LOGIN[TbUser.Text].SuperUser.Equals(1))
                {
                    isSup = false;
                }
                else if (Data.LOGIN[TbUser.Text].SuperUser == 0) { isSup = true; }


                Home h = new Home();
                    h.Title = "Midterm";
                    h.ShowDialog();
                

                }

            
           
            else
            {
                MessageBox.Show("Incporrect username or password", "Incorrect login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
      
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LgnWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
