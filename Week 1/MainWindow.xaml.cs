﻿using System;
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
        static Random r = new Random();
        List<Band> bands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create Rock Bands
            RockBand rb1 = new RockBand()
            {
                BandName = "Rock Band F",
                YearFormed = "2010",
                BandMembers = "sdfasdf, asdad, ASsa, gthth"
            };

            RockBand rb2 = new RockBand()
            {
                BandName = "Rock Band E",
                YearFormed = "2011",
                BandMembers = "sdfasdf, asdasd"
            };

            //Create Pop Bands
            PopBand pb1 = new PopBand()
            {
                BandName = "Pop Band A",
                YearFormed = "2012",
                BandMembers = "sdfasdf, sadad, adas"
            };

            PopBand pb2 = new PopBand()
            {
                BandName = "Pop Band B",
                YearFormed = "2013",
                BandMembers = "sdfasdf, sdfsdfsdf, sdfsdf"
            };

            //Create Indie Bands
            IndieBand ib1 = new IndieBand()
            {
                BandName = "Indie Band D",
                YearFormed = "2014",
                BandMembers = "sdfasdf, sdfsdf, sdfsdf"
            };

            IndieBand ib2 = new IndieBand()
            {
                BandName = "Indie Band C",
                YearFormed = "2015",
                BandMembers = "sdfasdf, asdasdasd, asdasdasd",
            };

            //Display list in the list box
            bands.Add(rb1);
            bands.Add(rb2);
            bands.Add(pb1);
            bands.Add(pb2);
            bands.Add(ib1);
            bands.Add(ib2);

            //Sort by date
            bands.Sort();

            //Display the activities in the listbox
            lbxBands.ItemsSource = null;
            lbxBands.ItemsSource = bands;

            //Populate the combo box
            cmbSelectGenre.Items.Add("Rock");
            cmbSelectGenre.Items.Add("Pop");
            cmbSelectGenre.Items.Add("Indie");

        }

        //CLicking on band name will display year formed and band members
        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;
            if (selectedBand != null)
            {
                tblkBandNameInfo.Text = selectedBand.BandName;
                tblkFormedInfo.Text = selectedBand.YearFormed;
                tblkMemberInfo.Text = selectedBand.BandMembers;
            }
        }

    }
}
