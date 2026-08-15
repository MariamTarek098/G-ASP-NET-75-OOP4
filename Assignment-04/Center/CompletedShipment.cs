using SmartDeliveryManagement.martDelivery;
using SmartDeliveryManagement.Ship;
using System;

namespace Assignment_03.Center
{
    internal sealed class CompletedShipment : Shipment
    {
        public DateTime CompletedDate { get; set; }

        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            DateTime completedDate)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CompletedDate = completedDate;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Completed Date: {CompletedDate}");
        }
    }
}