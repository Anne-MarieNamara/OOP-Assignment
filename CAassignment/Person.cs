using System;
using System.Collections.Generic;
using System.Text;

namespace CAassignment
{
    class Person
    {
        public string PPSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BorrowerID { get; set; }
        public int Booksborrowed { get; set; }
        public int Booksreturned { get; set; }

        public Person(string ppsn, string name, string address, string phone, string email, int booksborrowed, int booksreturned)
        {
            PPSN = ppsn;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            BorrowerID = BorrowerID;
            Booksborrowed = booksborrowed;
            Booksreturned = booksreturned;
        }

        // validate PPSN number
        public bool IsPPSN(string number)
        {
            if (number.Length < 8)
            {
                return false;

            }
            return true;
        }
    }
}




// validate phone number public
public bool IsValidPhone(string number)
{

    if (number.Length < 10)
    {
        return false;
    }
   

        return true;
}
    

    /*
    // validaate email
    public bool IsValidEmail(string email)
    {
        const string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+[a-zA-Z]{2,4}$;
        Match matches = regexPattern.Match(email, regexPattern)
                if (matches.Success)
        {
            return true;
        }
        else
        {
            throw new FormatException("Invalid email");
        }



    }
    */

    
   


