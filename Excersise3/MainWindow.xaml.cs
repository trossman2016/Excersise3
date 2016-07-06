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

namespace Excersise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            asciibutton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Handles the Click event of the gobutton control.
        /// Calculates the number of years, days, hours, minutes, and seconds in a user input.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs" /> instance containing the event data.</param>
        private void gobutton_Click(object sender, RoutedEventArgs e)
        {
            #region This was used for one of the class excersises
            //if (inputtextBox.Text != null && inputtextBox.Text != string.Empty)
            //{
            //    int x;
            //    bool parsed = int.TryParse(inputtextBox.Text, out x);

            //    double result = 0;
            //    if (parsed)
            //    {
            //        result = (3 * (Math.Pow((double)x, 3))) - (5 * (Math.Pow((double)x, 2))) + 6;
            //        outputtextbox.Text = result.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("The input was not valid. Please enter a number greater than zero.");
            //    }
            //} 
            #endregion

            int minute = 60; //The number of seconds in one minute
            int hour = minute * 60; //The number of seconds in one hour
            int day = hour * 24; //The number of seconds in one day
            int year = day * 365; //The number of seconds in one year

            int result; //The resulting int of the TryParse
            bool parsed = int.TryParse(inputtextBox.Text, out result);
            int years = 0; //The total number of years for the user input
            int days = 0; //The total number of days for the user input
            int hours = 0; //The total number of hours for the user input
            int minutes = 0; //The total number of minutes for the user input
            int seconds = 0; //The total number of seconds for the user input

            //If the user input is a valid int value
            if (parsed)
            {
                int runningcount = result;
                while (runningcount >= year)
                {
                    years++;
                    runningcount -= year;
                }
                while (runningcount >= day)
                {
                    days++;
                    runningcount -= day;
                }
                while (runningcount >= hour)
                {
                    hours++;
                    runningcount -= hour;
                }
                while (runningcount >= minute)
                {
                    minutes++;
                    runningcount -= minute;
                }
                seconds = runningcount;
            }
            string output = string.Format("{0} years, {1} days, {2} hours, {3} minutes and {4} seconds.", years, days, hours, minutes, seconds);
            outputtextbox.Text = output;
        }

        #region This was for one of the classroom assignments
        private void asciibutton_Click(object sender, RoutedEventArgs e)
        {
            //    int value;
            //    bool parsed = Int32.TryParse(inputtextBox.Text, out value);
            //    if (!parsed)
            //    {
            //        char firstChar = inputtextBox.Text[0];
            //        int x = (int)firstChar;
            //        outputtextbox.Text = x.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter text only.");
            //    }
        }
        #endregion
    }
}