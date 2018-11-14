/** Program 4
 *  CIS 200-01
    Fall 2017
    Due: 11/27/17
    By: C6643
    This class overrides the CompareTo method in the Parcel class. This 
    sort sorts by parcel type in ascending order before sorting by cost descending.**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelTypeAndCost : Comparer<Parcel>
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

            string parcel1 = p1.GetType().ToString();   // holds the parcel p1's type
            string parcel2 = p2.GetType().ToString();   // holds the parcel p2's type

            if (parcel1 == parcel2)
                return p1.CalcCost().CompareTo(p2.CalcCost());

            return parcel1.CompareTo(parcel2);


           
        }
    }
}
