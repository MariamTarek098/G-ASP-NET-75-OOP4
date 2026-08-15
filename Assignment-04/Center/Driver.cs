using SmartDeliveryManagement.Ship;
using System;

namespace Assignment_03.Center
{
    internal class Driver
    {
        private string fullName;
        private int driverId;
        private string phoneNumber;
        private Shipment assignedShipment;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Shipment AssignedShipment
        {
            get { return assignedShipment; }
        }

        public void AssignShipment(Shipment shipment)
        {
            assignedShipment = shipment;
        }
    }
}
