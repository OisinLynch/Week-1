using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    public abstract class Band : IComparable
    {
        //Properties
        public string BandName { get; set; }
        public string YearFormed { get; set; }
        public string BandMembers { get; set; }

        //Constructors
        public Band(string bandName, string yearFormed, string bandMembers)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            BandMembers = bandMembers;
        }

        public Band()
        {
        }

        //Methods

        public int CompareTo(object obj)
        {
            Band that = (Band)obj;

            //Compare one Activity Date to another 
            return this.BandName.CompareTo(that.BandName);
        }

        public override string ToString()
        {
            return $"{BandName} - ";
        }
    }

    public class RockBand : Band
    {

    }

    public class PopBand : Band
    {

    }

    public class IndieBand : Band
    {

    }
}
