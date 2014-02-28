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
                if (isTargetedVersion)
                {
                    // Get the new FlipTileData type.
                    Type flipTileDataType = Type.GetType("Microsoft.Phone.Shell.FlipTileData, Microsoft.Phone");

                    // Get the ShellTile type so we can call the new version of "Update" that takes the new Tile templates.
                    Type shellTileType = Type.GetType("Microsoft.Phone.Shell.ShellTile, Microsoft.Phone");

                    // Loop through any existing Tiles that are pinned to Start.
                    var tileToUpdate = ShellTile.ActiveTiles.First();


                    // Get the constructor for the new FlipTileData class and assign it to our variable to hold the Tile properties.
                    var UpdateTileData = flipTileDataType.GetConstructor(new Type[] { }).Invoke(null);

                    // Set the properties. 
                    SetProperty(UpdateTileData, "Title", "EMI Calculator");
                    //SetProperty(UpdateTileData, "Count", 12);
                    SetProperty(UpdateTileData, "BackTitle", "EMI Calculator");
                    SetProperty(UpdateTileData, "BackContent", "Calculate EMI of your Loans.");
                    SetProperty(UpdateTileData, "SmallBackgroundImage", new Uri("wp8_small.png", UriKind.Relative));
                    SetProperty(UpdateTileData, "BackgroundImage", new Uri("wp8_medium.png", UriKind.Relative));
                    SetProperty(UpdateTileData, "BackBackgroundImage", new Uri("wp8_back_medium.png", UriKind.Relative));
                    SetProperty(UpdateTileData, "WideBackgroundImage", new Uri("wp8_large.png", UriKind.Relative));
                    SetProperty(UpdateTileData, "WideBackBackgroundImage", new Uri("wp8_back_large.png", UriKind.Relative));
                    SetProperty(UpdateTileData, "WideBackContent", "Content for Wide Back Tile. Lots more text here.");

                    // Invoke the new version of ShellTile.Update.
                    shellTileType.GetMethod("Update").Invoke(tileToUpdate, new Object[] { UpdateTileData });


                }
                else
                {
                    StandardTileData newTile = new StandardTileData
                    {
                        Title = "EMI Calculator",
                        BackgroundImage = new Uri("tile_image.png", UriKind.Relative),
                        //Count = 12,
                        BackTitle = "EMI Calculator",
                        BackBackgroundImage = new Uri("back_image.png", UriKind.Relative),
                        BackContent = "Calculate EMI of your Loans."
                    };
                    appTile.Update(newTile);
                }

            }

        }
        private static void SetProperty(object instance, string name, object value)
        {
            var setMethod = instance.GetType().GetProperty(name).GetSetMethod();
            setMethod.Invoke(instance, new object[] { value });
        }

        private void rst()
        {
            principal.Text = "";
            rate.Text = "";
            time.Text = "";
            emi.Text = "";
            sumPaid.Text = "";
            totalInterest.Text = "";
        }

        private void calc(){
            try
            {
                double p = double.Parse(principal.Text);
                double i = double.Parse(rate.Text);
                double n = double.Parse(time.Text);
                i /= 1200;
                double a = p * (i * Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n) - 1);
                double amnt = a * n;
                double itot = amnt - p;
                a = Math.Round(a, 0);
                amnt = Math.Round(amnt, 0);
                itot = Math.Round(itot, 0);
                emi.Text = a.ToString();
                sumPaid.Text = amnt.ToString();
                totalInterest.Text = itot.ToString();
            }
            catch (Exception)
            {
                if ((principal.Text == "" || rate.Text == "" || time.Text == ""))
                {
                    MessageBox.Show("Please enter values in the respective fields !");
                    
                }
            }
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
            calc();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            rst();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/help.xaml", UriKind.Relative));
        }
        
        
    }
}