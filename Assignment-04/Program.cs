using Management_System.Ship;
using SmartDeliveryManagement.Center;
using SmartDeliveryManagement.martDelivery;
using SmartDeliveryManagement.Ship;
using Assignment_03.Center;
using System;

namespace Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // Part 01
            // ==========================================

            // Q1
            // a)
            // process of hiding unnecessary implementation details and showing only the
            // essential features of an object.

            // b)
            // Because it hides unnecessary details and shows only the essential parts,
            // making code simpler and easier to maintain.

            // Q2
            // a) An abstract class can contain both implemented and abstract methods, while an interface mainly defines a contract that classes must implement.
            // b) I choose an interface when I want different, unrelated classes to follow the same contract or behavior.
            // c) No, a class can inherit from only one abstract class, but it can implement multiple interfaces.



            // =========================================================================
            // Part 02 
            // =========================================================================

            // a. Create one StandardShipment
            StandardShipment standardShipment = new StandardShipment(
                "SH001",
                "Laptop",
                9m,
                50m,
                new DeliveryAddress("Cairo", "Main St", 1)
            );

            // b. Create one ExpressShipment
            ExpressShipment expressShipment = new ExpressShipment(
                "SH002",
                "Mobile Phone",
                4m,
                50m,
                new DeliveryAddress("Cairo", "Main St", 1),
                30m
            );

            // c. Create one InternationalShipment
            InternationalShipment internationalShipment = new InternationalShipment(
                "SH003",
                "Documents",
                10m,
                50m,
                new DeliveryAddress("Cairo", "Main St", 1),
                "Germany",
                160m
            );

            // d. Add all shipments to the DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            // e. Print all shipment details
            center.PrintAllShipments();

            // f and h 
            ITrackable[] trackableShipments = new ITrackable[]
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            foreach (ITrackable trackable in trackableShipments)
            {
                DeliveryReport.PrintShipment(trackable);
            }

            // g and  i 
            IInsurable[] insurableShipments = new IInsurable[]
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            foreach (IInsurable insurable in insurableShipments)
            {
                DeliveryReport.PrintInsurance(insurable);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }
    }
}