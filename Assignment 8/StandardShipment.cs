using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8
{
    #region Three Shipment Types : StandardShipment

    internal class StandardShipment : Shipment
    {
        #region Constructor

        public StandardShipment(string TrackingCode) : base(TrackingCode) { }
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        #endregion

        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();

            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        #endregion
    }

    #endregion
}
