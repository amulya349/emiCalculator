using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace emiCaluclator
{

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        private static Version TargetedVersion = new Version(7, 10, 8858);
        public static bool isTargetedVersion { get { return Environment.OSVersion.Version >= TargetedVersion; } }
        public MainPage()
        {
            InitializeComponent();
            ShellTile appTile = ShellTile.ActiveTiles.First();
            if (appTile != null)
            {
                StandardTileData newTile = new StandardTileData
                {
                    Title = "EMI Calculator",
                    BackgroundImage = new Uri("tile_image.png", UriKind.Relative),
                    
                    BackTitle = "EMI Calculator ",
                    BackBackgroundImage = new Uri("back_image.png", UriKind.Relative),
                    BackContent = "Calculate EMI for your Loans"
                };
                appTile.Update(newTile);
            }
        }
        private void calc(){
            double p = double.Parse(principal.Text);
            double i = double.Parse(rate.Text);
            i/=1200;
            double n = double.Parse(time.Text);
            double a = p*( i * Math.Pow(1+i, n))/(Math.Pow(1+i, n) - 1);
            double amnt = a * n;
            double itot = amnt - p;
            a = Math.Round(a, 0);
            amnt = Math.Round(amnt, 0);
            itot = Math.Round(itot, 0);
            emi.Text = a.ToString();
            sumPaid.Text= amnt.ToString();
            totalInterest.Text= itot.ToString();
        }

        private void principal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
           /* try
            {
                calc();
            }
            catch (Exception caught)
            {
                emi.Text = "";
                sumPaid.Text = caught.Message;
            }*/
            calc();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            principal.Text="";
            rate.Text = "";
            time.Text = "";
            emi.Text = "";
            sumPaid.Text = "";
            totalInterest.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/help.xaml", UriKind.Relative));
        }
       
        
    }
}