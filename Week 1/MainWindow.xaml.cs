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

namespace Week_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> bands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create Bands
            Band b1 = new Band()
            {
                BandName = "F",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            Band b2 = new Band()
            {
                BandName = "E",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            Band b3 = new Band()
            {
                BandName = "A",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            Band b4 = new Band()
            {
                BandName = "B",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            Band b5 = new Band()
            {
                BandName = "D",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            Band b6 = new Band()
            {
                BandName = "C",
                YearFormed = 2010,
                BandMembers = "sdfasdf"
            };

            //Display list in the list box
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            //Sort by date
            bands.Sort();

            //Display the activities in the listbox
            lbxBands.ItemsSource = null;
            lbxBands.ItemsSource = bands;
        }
    }
}
