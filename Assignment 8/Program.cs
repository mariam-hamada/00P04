using System.Diagnostics.Contracts;

namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Question 1

            // a)  What is Abstraction in Object - Oriented Programming?
            //hiding unnecessary implementation details and showing only the essential features of an object. It focuses on what an object does rather than how it does it.

            // b)  Why is abstraction considered one of the four pillars of OOP ?
            //helps reduce complexity, hide implementation details, improve code organization, and make programs easier to maintain and use.


            #endregion

            #region Question 2

            //a)  What is the difference between an Abstract Class and an Interface?

            //Abstract Class: A class that cannot be instantiated.It can contain abstract methods, normal methods, fields, properties, and constructors.A class can inherit from only one abstract/base class.
            //Interface: Defines a contract that a class must follow.It mainly specifies methods, properties, and other members that the implementing class must provide.A class can implement multiple interfaces.

            //b)  When would you choose an Interface instead of an Abstract Class?
            //When different, unrelated classes need to share the same behavior or contract, without needing to share common implementation or data.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            //A class cannot inherit from multiple classes(including abstract classes), but A class can implement multiple interfaces.


            #endregion

            #endregion

            #region Part 02 — Practical

            #region   a. Create one StandardShipment.

            StandardShipment standardShipment = new StandardShipment
                (
                "SH001",
                "Laptop",
                3,
                80,
                new DeliveryAddress("Cairo", "Nasr Street", 10)
                );

            #endregion

            #region b.Create one ExpressShipment.

            ExpressShipment expressShipment = new ExpressShipment
                (
                "SH002",
                "Mobile Phone",
                2,
                60,
                new DeliveryAddress("Giza", "Nile Street", 20),
                30
                );

            #endregion

            #region c.Create one InternationalShipment.

            InternationalShipment internationalShipment = new InternationalShipment
                (
                "SH003",
                "Television",
                8,
                120,
                new DeliveryAddress("Alexandria", "Corniche Street", 30),
                "Germany",
                100
                );

            #endregion

            #region d. Add all shipments to the DeliveryCenter.

            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment (internationalShipment);
            #endregion

            #region e. Print all shipment details.

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            center.PrintAllShipments();
            Console.WriteLine("==========================================");

            #endregion

            #region f. Print the tracking status of every shipment.

            Console.WriteLine(standardShipment.GetTrackingStatus());
            Console.WriteLine(expressShipment.GetTrackingStatus());
            Console.WriteLine(internationalShipment.GetTrackingStatus());
            Console.WriteLine();
            Console.WriteLine("==========================================");

            #endregion

            #region g. Print the insurance cost of every shipment.

            Console.WriteLine($"Standard Shipment Insurance : {standardShipment.CalculateInsurance()} EGP");
            Console.WriteLine($"Express Shipment Insurance : {expressShipment.CalculateInsurance()} EGP");
            Console.WriteLine($"International Shipment Insurance : {internationalShipment.CalculateInsurance()} EGP");
            Console.WriteLine();
            Console.WriteLine("==========================================");

            #endregion

            #region h. Store shipment objects in an ITrackable[] array and print their tracking statuses.

            ITrackable[] trackableShipments =
                {
                standardShipment, expressShipment, internationalShipment
                };
            foreach(ITrackable shipment in trackableShipments)
            {
                Console.WriteLine($"Shipment tracking status is : {shipment.GetTrackingStatus()}");
            }
            Console.WriteLine();
            Console.WriteLine("==========================================");


            #endregion

            #region i. Store shipment objects in an IInsurable[] array and print their  insurance values.

            IInsurable[] insurablesShipments =
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            foreach(IInsurable shipment in insurablesShipments)
            {
                Console.WriteLine($"Shipment Insurance is : {shipment.CalculateInsurance()}");
            }
            Console.WriteLine();
            Console.WriteLine("==========================================");

            #endregion

            #endregion
        }
    }
}
