﻿// Program 4
// CIS 200-01
// Fall 2017
// Due: 11/27/2017
// By: C6643

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }

    // Precondition: None
    // Post condition: A parcel is compared to this. When this is < p2 a negative number is returned
    //                 When this == p2, zero is returned
    //                 When this > p2, a positive number is returned
  public int CompareTo(Parcel p2)
    {
        if (this == null && p2 == null)
            return 0;

        if (this == null)
            return -1;

        if (p2 == null)
            return 1;

        return (this.CalcCost().CompareTo(p2.CalcCost()));
    }
}
