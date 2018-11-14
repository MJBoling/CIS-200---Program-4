// Program 4
// CIS 200-01
// Fall 2017
// Due: 11/27/2017
// By: C6643

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            // Letter test objects
            Letter l1 = new Letter(a1, a2, 3.95M);
            Letter l2 = new Letter(a1, a3, 0.50M); 
            Letter l3 = new Letter(a2, a4, 1.20M); 
            Letter l4 = new Letter(a4, a1, 1.70M); 
            
            // GroundPackage test objects
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);
            GroundPackage gp2 = new GroundPackage(a1, a4, 20, 20, 20, 50); 
            GroundPackage gp3 = new GroundPackage(a2, a4, 10, 10, 05, 10); 
                                                                           
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a3, 50, 50, 20, 20, 10.50m);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            // Add parcels to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(l4);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap1);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();


            parcels.Sort();
            Console.Out.WriteLine("Sorted list(by cost ascending):");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescDestZipCode());
            Console.WriteLine("Sorted list(by Destination Zip Code descending):");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
                Pause();

            parcels.Sort(new ParcelTypeAndCost());
            Console.WriteLine("Sorted list(by Parcel Type Ascending and Cost descending):");
            Console.WriteLine("====================");
            foreach(Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
