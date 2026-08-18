using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8
{
    internal abstract class Shipment
    {
        #region Attributes

        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;

        #endregion


        #region Properties

        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public virtual decimal EstimatedCost
        {
            get
            {
                return _deliveryFee + (_weight * 5);
            }
        }

        #endregion


        #region Constructors

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Cairo", "Tahrir", 10);
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion


        #region Methods

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            decimal totalWeight = newWeight + extraPackingWeight;

            if (totalWeight > 0)
                Weight = totalWeight;
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine(
                $"Our Shipment details is:\n" +
                $"1. Tracking code: {_trackingCode}\n" +
                $"2. Description: {_description}\n" +
                $"3. Weight: {_weight} kg\n" +
                $"4. Delivery Fee: {_deliveryFee} EGP\n" +
                $"5. Destination: {Destination.GetFullAddress()}\n" +
                $"6. Estimated Cost: {EstimatedCost} EGP");
        }

        #endregion
    }
}
