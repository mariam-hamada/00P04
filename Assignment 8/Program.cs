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
        }
    }
}
