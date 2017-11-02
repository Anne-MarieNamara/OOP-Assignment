using System;
using System.Collections.Generic;
using System.Text;

namespace CAassignment
{
    class Staff : Person
    {
        int id;
        double salary;

        public Staff(string ppsn, string name, string address, string phone, string email, int id, double salary) : base(ppsn, name, address, phone, email)
        {
            this.id = id;
            this.salary = salary;

        }
    }

    
}
