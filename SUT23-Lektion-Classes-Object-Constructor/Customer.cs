using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Lektion_Classes_Object_Constructor
{
    internal class Customer
    {
        public int _id;
        public string _firstName;
        public string _lastName;
        public bool _isActive;


        public Customer() : this(00, "No Data Provided", "No Data", false)
        {

        }

        public Customer(int Id,string FirstName,string LastName,bool isActive)
        {
            this._id = Id;
            this._firstName = FirstName;
            _lastName = LastName;
            _isActive = isActive;


        }
        public void PrintData()
        {
            Console.WriteLine("User ID : {0}", _id);
            Console.WriteLine("User Full Name : {0}", _firstName + " " + _lastName);
            if (_isActive)
            {
                Console.WriteLine("The User is Active");
            }
            else
            {
                Console.WriteLine("The User is not active");
            }
        }

    }
}
