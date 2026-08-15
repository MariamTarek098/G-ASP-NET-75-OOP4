using SmartDeliveryManagement.Ship;

namespace Assignment_03.Center
{
    internal static class DeliveryHelper
    {
        public static decimal CalculateTotalCost(Shipment[] shipments)
        {
            decimal totalCost = 0;

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    totalCost += shipments[i].EstimatedCost;
                }
            }

            return totalCost;
        }
    }
}