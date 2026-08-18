using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8
{
    internal sealed class CompletedShipment : Shipment
    {
        #region Constructor

        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        #endregion
    }
}
