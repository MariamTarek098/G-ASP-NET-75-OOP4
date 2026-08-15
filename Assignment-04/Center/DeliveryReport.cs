using Management_System.Ship;
using SmartDeliveryManagement.Ship;
using System;

namespace SmartDeliveryManagement.Center
{
    internal class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                string label = shipment switch
                {
                    StandardShipment => "Standard Shipment Insurance",
                    ExpressShipment => "Express Shipment Insurance",
                    InternationalShipment => "International Shipment Insurance",
                    _ => $"{shipment.GetType().Name} Insurance"
                };

                Console.WriteLine($"{label} : {shipment.CalculateInsurance():0.00} EGP");
            }
        }
    }
}
