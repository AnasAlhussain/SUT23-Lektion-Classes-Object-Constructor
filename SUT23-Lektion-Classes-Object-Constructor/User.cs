using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Lektion_Classes_Object_Constructor
{
    internal class User
    {
        public string _firsName;
        public string _lastName;


        public User():this("No First Name","No Last Name Provided")
        {

        }
        public User(string FirstNAme , string LastName)
        {
            _firsName = FirstNAme;
            _lastName= LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name is : {0}", _firsName + " " + _lastName);
        }

        ~User()
        {
            //rensa upp koden från minnet 
        }
    }
}
