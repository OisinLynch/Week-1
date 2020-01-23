using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Album
    {
        //Properties
        public string AlbumName { get; set; }
        public int YearReleased { get; set; }
        public int Sales { get; set; }

        //Constructors
        public Album(string albumName, int yearReleased, int sales)
        {
            AlbumName = albumName;
            YearReleased = yearReleased;
            Sales = sales;
        }
    }
}
