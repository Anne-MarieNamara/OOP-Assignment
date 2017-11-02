using System;
using System.Collections.Generic;
using System.Text;

namespace CAassignment
{

    class College
    {

       public static List<Student> students = new List<Student>();
        List<Lecturer> lecturers = new List<Lecturer>();

        public static void Main(string[] args)
        {
            // method to return to the menu after each option is completed
            bool displayMenu = true;
            College college = new College();
            while (displayMenu == true)
            {
                displayMenu = college.MainMenu();
            }
        }

        public bool MainMenu()
        {
            // create a list to hold all the student objects
            students.Add(new Student("12345b", "Anne-Marie", "Winterfell", "123457", "dragonsrfly@got.com", 3, 1, true, 1037));

            // create a list to hold all the lecturer objects
            lecturers.Add(new Lecturer("12345b", "Anne-Marie", "Winterfell", "123457", "dragonsrfly@got.com", 2, 3, 4));

            // Menu
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("Option 1: Add Student");
            Console.WriteLine("Option 2: Add Lecturer");
            Console.WriteLine("Option 3: Book Loan");
            Console.WriteLine("Option 4: Book Return");
            Console.WriteLine("Option 5: Search For Student");
            Console.WriteLine("Option 6: Search For Lecturer");
            Console.WriteLine("Option 7: Deatils of all enrolled students");
            Console.WriteLine("Option 8: Names of all lecturers");
            Console.WriteLine("Option 9: Exit");



            // taking choice from user as an input and storing it in a variable called option
            string option = Console.ReadLine();
            string ppsn = "";
            string name = "";
            string address = "";
            string phoneNum = "";
            string email = "";
            bool status = true;
            int borrowerID = 0;
            int booksborrowed = 0;
            int booksreturned = 0;
            int studentID = "";
            int subjects = 0;

            //Prompt user for info for option 1 to create student object
            if (option == "1")
            {
                Console.WriteLine("Enter your pps number: ");
                ppsn = Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your address: ");
                address = Console.ReadLine();
                Console.WriteLine("Enter your phone number: ");
                phoneNum = Console.ReadLine();
                Console.WriteLine("Enter your email");
                email = Console.ReadLine();
                Console.WriteLine("Enter your StudentID");
                studentID = int.Parse((Console.ReadLine()));
                Console.WriteLine("Enter your borrowerID");
                borrowerID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your status");
                status = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Please enter the number of books to borrow");
                booksborrowed = Convert.ToInt32(Console.ReadLine());

                if (!borrowBook(status, booksborrowed))
                {
                    Console.WriteLine("Sorry you can't borrow any books");
                }

                // Add student object into list called students
                students.Add(new Student(ppsn, name, address, phoneNum, email, booksborrowed, booksreturned, status, studentID));

                // return to menu
                return true;

            }
            // prompt user for info from option 2 to create lecturer object
            else if (option == "2")
            {
                Console.WriteLine("Enter your pps number: ");
                ppsn = Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your address: ");
                address = Console.ReadLine();
                Console.WriteLine("Enter your phone number: ");
                phoneNum = Console.ReadLine();
                Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();
                Console.WriteLine("Enter your borrowerID: ");
                borrowerID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of subjects you teach: ");
                subjects = int.Parse(Console.ReadLine());

                    // Add lecturer object into list called lecturers
                lecturers.Add(new Lecturer(ppsn, name, address, phoneNum, email, booksborrowed, booksreturned, subjects));

                // return to menu
                return true;
            }

            else if (option == "3")
            {
                Console.WriteLine(("what is your borrowerID?: "));
                int borrowerid = int.Parse(Console.ReadLine());
                LoanBook(""); // string will call pps = Lecturer
                LoanBook(12); // int will cvall studentID = Student
                return true;

            }
            else if (option == "4")
            {
                ReturnBook();
                return true;
            }
            else if (option == "5")
            {
                Console.WriteLine("please enter your studentID");
                string id = Console.ReadLine();
                Student searchedStudent = searchForStudent(id);
                if (searchedStudent != null)
                {
                    Console.WriteLine("found Student and his details are ");
                    Console.WriteLine(searchedStudent.ToString());
                }
                else
                {
                    Console.WriteLine("Sorry no student is present with the studentID " + id);
                }
                return true;
            }
            else if (option == "6")
            {
                Console.WriteLine("please enter your ppsn to search for a lecturer");
                string pps = Console.ReadLine();
                Lecturer searchedLecturer = searchForLecturer(pps);
                if (searchedLecturer != null)
                {
                    Console.WriteLine("found Lecturer and his details are ");
                    Console.WriteLine(searchedLecturer.ToString());
                }
                else
                {
                    Console.WriteLine("Sorry no lecturer is present with the ppsn " + ppsn);
                }
                return true;
            }
            else if (option == "7")
            {
                ShowEnrolled();
                return true;
            }

            else if ( option == "8")
            {
                ShowNamesOfLecturers();
                return true;
            }
            else if ( option == "9")
            {
                return false;
            }

            else
            {
                Console.WriteLine("Invalid option choice. \n Please choose from options 1 - 4");
                //  Go back to Menu here
                return true;
            }

            Console.ReadLine();
        }

       


        public Student searchForStudent(int studentID)
        {
            foreach (Student student in students)
            {
                if(student.StudentID == studentID)
                {
                    return student;
                }
            }
            return null;
        }

        public Lecturer searchForLecturer(string ppsn)
        {
            foreach (Lecturer lecturer in lecturers)
            {
                if (lecturer.PPSN == ppsn)
                {
                    return lecturer;
                  
                }
            }
            return null;
        }





        // show the details of all enrolled students
        public void ShowEnrolled()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

        }

        // Show the names of all lecturers
        public void ShowNamesOfLecturers()
        {
            foreach (Lecturer lecturer in lecturers)
            {
                Console.WriteLine(lecturer.Name);
            }
        }


     

        public void LoanBook(int studentID)
        {
            Student student = searchForStudent(studentID);
          
                if ((student.Status == true && student.Booksborrowed >= 5) || (student.Status == false && student.Booksborrowed >= 10))
                {
                    Console.WriteLine("You cannot take any more books out");
                }
                else
                {
                    student.Booksborrowed++;
                    Console.WriteLine("You have taken out a book");
                }
            
        }

        public void LoanBook(string ppsn)
        {
            Lecturer lecturer = searchForLecturer(ppsn);
           
                GetBookBalance(int booksborrowed);
                booksborrowed++;
                Console.WriteLine("You have taken out a book \n Your book balance is:{0}", booksborrowed);
                Console.ReadLine();
            
        }

        public static void ReturnBook(int borrowerid, int booksborrowed)
        {
            foreach (/*List<Student>*/Student s in students)
            {
                if ((s.status == "undergrad") || (student.status == "postgrad"))
                {
                    booksborrowed--;
                    Console.WriteLine("Books borrowed balance is: {0}");
                }
            }
            foreach (List<Lecturer> lecturer in lecturers)
            {
                booksborrowed--;
                Console.WriteLine("You have returned a book");
            }

        }

        public static int GetBookBalance(int booksborrowed, int booksreturned)
        {
            int bookbalance = booksreturned - booksborrowed;
            return bookbalance;
        }

        public static bool borrowBook(bool status, int Booksborrowed)
        {
            if (status == true)
            { // undergrad
                if (Booksborrowed < 5)
                {
                    Booksborrowed++;
                }
                else
                {
                    return false; // he can't borrow a book
                }
            }
            else
            { // postgrad
                if (Booksborrowed < 10)
                {
                    Booksborrowed++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
   }
