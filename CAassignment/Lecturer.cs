using System;
using System.Collections.Generic;
using System.Text;


    namespace CAassignment
    {
        class Lecturer : Person
        {
            public int Subjects { get; set; }


            public Lecturer(string ppsn, string name, string address, string phone, string email, int booksborrowed, int booksreturned, int subjects) : base(ppsn, name, address, phone, email, booksborrowed, booksreturned)
            {
                this.Subjects = subjects;
            }

        public override string ToString()
        {
            // concatenating the details of lecturer for the ToString method
            return "ppsn:" + PPSN + "\nname" + Name + "\naddress" + Address + "\nphone" + Phone + "\nemail" + Email +
                "\nbooksborrowed" + Booksborrowed + "\nbooksreturned" + Booksreturned + "\nsubjects:" + Subjects;

        }
    }
    }

