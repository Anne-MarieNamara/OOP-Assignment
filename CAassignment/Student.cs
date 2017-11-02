using System;{
using System.Collections.Generic;
using System.Text;

namespace CAassignment
{
    class Student : Person
    {
        public bool Status { get; set; } // status true = undergrad, false = postgrad
        public int StudentID { get; set; }


        public Student(string ppsn, string  name, string address, string phone, string email, int booksborrowed, int booksreturned,
            bool status, int studentID):base(ppsn, name, address, phone, email, booksborrowed, booksreturned)
        {
            this.Status = status;
            this.StudentID = studentID;
        }

        public override string ToString()
        {
            // concatenating the details of student for the ToString method
            return "ppsn:" + PPSN + "\nname" + Name + "\naddress" + Address + "\nphone" + Phone + "\nemail" + Email  +
                "\nbooksborrowed" + Booksborrowed + "\nbooksreturned" + Booksreturned + "\nStatus:" + Status + "\nStudentID" + StudentID; 
            
        }

        public bool getstatus()
        {
            return this.Status;
        }


        /* private string status;
         private string studentID;

         public Student(string ppsn, string name, string address, string phone, string email, string status, string studentID) : base( ppsn, name, address, phone, email)
         {
             this.status = status;
             this.studentID = studentID;

         }

         public String toString()
         {
             return "ppsn: " + getPpsn() + "\nStatus : " + status + "\nStudent Id " + studentID;
         }


         public string getstatus()
         {
             return this.status;
         }

         public void setstatus(string ppsn, bool status)
           status = undergrad;
         {
             this.status = status;
             if (status = true)
             {
                 loan = 5;
             }
                 else
             {
                 loan = 10;
             }
         }*/

    }


    
}
