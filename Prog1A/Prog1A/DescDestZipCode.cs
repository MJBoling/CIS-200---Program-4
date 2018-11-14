/** Program 4
 *  CIS 200-01
    Fall 2017
    Due: 11/27/17
    By: C6643
    This class creates a sort that overrides the CompareTo method in the abstract Parcel class. 
    This sort sorts by destination zip code and orders it in descending order.**/
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescDestZipCode : Comparer<Parcel>
    {
        // Precondition: None
        // Postcondition: When p1 and p2 are equal 0 is returned
        //                When p1 is less than p2, -1 is returned
        //                When p2 is less than p1, 1 is returned
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip);
        }
    }
}
