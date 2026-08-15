using SmartDeliveryManagement.martDelivery;
using System;

namespace Management_System.Ship
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            Console.WriteLine("Priority Handling: Express Customs Clearance Applied.");
        }
    }
}
