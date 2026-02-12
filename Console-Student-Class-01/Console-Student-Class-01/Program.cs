namespace Console_Student_Class_01
{
    internal class Program
    {
        // Method to register a student
        public static Student RegisterStudent()
        {
            Console.WriteLine("\nEnter Student ID:");
            // int studentID = Convert.ToInt32(Console.ReadLine());

            // Check if input is a valid number
            int studentID;
            if (!int.TryParse(Console.ReadLine(), out studentID))
            {
                throw new ArgumentException("Student ID must be a number.");
            }

            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();

            // Check if name exceeds 10 characters
            if (studentName.Length > 10)
            {
                throw new ArgumentException("Student Name must not exceed 10 characters.");
            }


            //Console.WriteLine("Enter Student Surname:");
            //string studentSurname = Console.ReadLine();

            //Console.WriteLine("Enter Student Email:");
            //string studentEmail = Console.ReadLine();

            // Create and return the student object
            Student student = new Student
            {
                StudentID = studentID,
                StudentName = studentName,
                //StudentSurname = studentSurname,
                //StudentEmail = studentEmail
            };

            return student;
        }

        public static void DisplayStudentList(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("\nNo students registered.");
                return;
            }
            Console.WriteLine("\nRegistered Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentID}, Name: {student.StudentName}");
            }
        }

        public static void DisplayStudentInfo(Student student)
        {
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Student Name: {student.StudentName}");
            Console.WriteLine($"Student Surname: {student.StudentSurname}");
            Console.WriteLine($"Student Email: {student.StudentEmail}");
        }

        public static void FindStudentByID(List<Student> students, int studentID)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            if (student != null)
            {
                DisplayStudentInfo(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void Main(string[] args)
        {
            Course course = new Course
            {
                CourseID = 1,
                CourseName = "Mathematics",
                CourseCode = "MATH101",
                CourseCredit = 3
            };
            Course course2 = new Course
            {
                CourseID = 2,
                CourseName = "Physics",
                CourseCode = "PHYS101",
                CourseCredit = 4
            };
            Course course3 = new Course
            {
                CourseID = 3,
                CourseName = "Chemistry",
                CourseCode = "CHEM101",
                CourseCredit = 3
            };
            List<Course> courses = new List<Course> { course, course2, course3 };
            List<Student> students = new List<Student>();

            foreach (var item in courses)
            {
                Console.WriteLine($"Course ID: {item.CourseID}, Course Name: {item.CourseName}, Course Code: {item.CourseCode}, Course Credit: {item.CourseCredit}");
            }

            bool exit = false;

            while (!exit)
            {
                try
                {
                    // Display the menu
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Student Registration System");
                    Console.WriteLine("Total Student Count = " + students.Count);
                    Console.WriteLine("1 - Register Student");
                    Console.WriteLine("2 - Display All Students");
                    Console.WriteLine("3 - Find Student by ID");
                    Console.WriteLine("4 - Exit");

                    // Get user input
                    Console.Write("Please enter your choice: ");
                    string userChoice = Console.ReadLine();

                    if (userChoice == "1")
                    {
                        // Register a new student
                        Student student = RegisterStudent();

                        Student? checkStudent =  students.Where(s => s.StudentID == student.StudentID).FirstOrDefault();
                        if (checkStudent != null)
                        {
                            throw new ArgumentException("A student with this ID already exists. Student ID must be unique. Please Try Again.");
                        }

                        students.Add(student);
                        Console.WriteLine($"Student Registered: {student.StudentName} {student.StudentSurname}");
                    }
                    else if (userChoice == "2")
                    {
                        // Display all registered students
                        DisplayStudentList(students);
                    }
                    else if (userChoice == "3")
                    {
                        // Find a student by ID
                        Console.Write("Enter Student ID to find: ");
                        int studentID = Convert.ToInt32(Console.ReadLine());
                        FindStudentByID(students, studentID);
                    }
                    else if (userChoice == "4" || userChoice.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        // Exit the program
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                    }
                    else
                    {
                        // Invalid input
                        Console.WriteLine("Invalid choice, please try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Catch any validation errors and show the error message
                    Console.WriteLine($"Error: {ex.Message}");
                }                
            }

            Console.ReadLine();
        }
    }
}
