using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class Student
    {

        private string name;
        private int semester;
        private string department;
        private string university;
        private float cgpa;
        private int id;
        
        public int id1
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int semester1
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }

        public string name1
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string department1
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string university1
        {
            get
            {
                return university;
            }
            set
            {
                university = value;
            }
        }

        public float cgpa1
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }
        public Student()
        {
            id = 0;


        }

        ~Student()
        {
             Console.WriteLine("Destructor was called");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            char choice2 = 'n';
            int c = 0;
            do
            {

                string choice="0";
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Create Student profile");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Delete Student Record");
                Console.WriteLine("4. List top 03 of class");
                Console.WriteLine("5. Mark student attendance");
                Console.WriteLine("6. View attendance:");
                choice = Console.ReadLine();
                Student[] obj = new Student[100];
                if (choice == "1")
                {
                    obj[c] = new Student();
                    Console.WriteLine("- Enter Student ID (Unique)");
                    obj[c].id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("- Enter Student Name");
                    obj[c].name1 = Console.ReadLine();
                    Console.WriteLine("- Enter Student Semester");
                    obj[c].semester1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("- Enter Student CGPA");
                    obj[c].cgpa1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("- Enter Student Department");
                    obj[c].department1 = Console.ReadLine();
                    Console.WriteLine("- Enter Student University");
                    obj[c].university1 = Console.ReadLine();
                    c++;
                }


                string searchName;
                string searchNameCheck = "123";
                int searchId;
                int checkSearchId = -1;
                int choice1 = 0;
                if (choice == "2")
                {
                    Console.WriteLine("Please select one of the following options:");
                    Console.WriteLine("1. Search By ID (Will only return 1 student)");
                    Console.WriteLine("2. Search By Name (Will return all student having same name)");
                    Console.WriteLine("3. List Number of Students (With selecting option 3 list of all students will be displayed)");
                    choice1 = Convert.ToInt32(Console.ReadLine());

                    if (choice1 == 1)
                    {
                        Console.WriteLine("Enter ID");
                        searchId = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i <= c; i++)
                        {
                            if (searchId == obj[i].id1)
                            {
                                checkSearchId = obj[i].id1;
                                Console.WriteLine("ID:");
                                Console.WriteLine(obj[i].id1);
                                Console.WriteLine("Name:");
                                Console.WriteLine(obj[i].name1);
                                Console.WriteLine("Semester:");
                                Console.WriteLine(obj[i].semester1);
                                Console.WriteLine("CGPA:");
                                Console.WriteLine(obj[i].cgpa1);
                                Console.WriteLine("Department:");
                                Console.WriteLine(obj[i].department1);
                                Console.WriteLine("University:");
                                Console.WriteLine(obj[i].university1);
                            }
                        }
                        if (checkSearchId == -1)
                        {
                            Console.WriteLine("Record Not Found");
                        }

                    }

                    if (choice1 == 2)
                    {
                        Console.WriteLine("Enter Name");
                        searchName = Console.ReadLine();
                        for (int i = 0; i <= c; i++)
                        {
                            if (obj[i].name1 == searchName)
                            {
                                searchNameCheck = obj[i].name1;
                                Console.WriteLine("ID:");
                                Console.WriteLine(obj[i].id1);
                                Console.WriteLine("Name:");
                                Console.WriteLine(obj[i].name1);
                                Console.WriteLine("Semester:");
                                Console.WriteLine(obj[i].semester1);
                                Console.WriteLine("CGPA:");
                                Console.WriteLine(obj[i].cgpa1);
                                Console.WriteLine("Department:");
                                Console.WriteLine(obj[i].department1);
                                Console.WriteLine("University:");
                                Console.WriteLine(obj[i].university1);
                            }
                        }
                        if (searchNameCheck == "123")
                        {
                            Console.WriteLine("Record not found");
                        }
                    }

                    if (choice1 == 3)
                    {
                        Console.WriteLine("Total Number of Students in the database = " + c);
                        for (int i = 0; i <= c; i++)
                        {
                            checkSearchId = obj[i].id1;
                            Console.WriteLine("ID:");
                            Console.WriteLine(obj[i].id1);
                            Console.WriteLine("Name:");
                            Console.WriteLine(obj[i].name1);
                            Console.WriteLine("Semester:");
                            Console.WriteLine(obj[i].semester1);
                            Console.WriteLine("CGPA:");
                            Console.WriteLine(obj[i].cgpa1);
                            Console.WriteLine("Department:");
                            Console.WriteLine(obj[i].department1);
                            Console.WriteLine("University:");
                            Console.WriteLine(obj[i].university1);
                        }

                    }

                }
                if (choice=="3")
                {                    
                    Console.WriteLine("Please Enter ID of the student");
                    int search = Convert.ToInt32(Console.ReadLine());
                    for (int i=0;i<c;i++)
                    {
                        if (search==obj[i].id1)
                        {
                            obj[i]=null;
                        }
                    }
                }
                
                Console.WriteLine("Enter y to enter main menu");
                choice2 = Convert.ToChar(Console.ReadLine());
            } while (choice2 == 'y' || choice2=='Y');

            Console.ReadKey();
        }
    }
}
