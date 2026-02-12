namespace Console_Student_Class_01
{
    internal class Program
    {
        // Method to register a student
        public static Student RegisterStudent()
        {
            Console.WriteLine("\nEnter Student ID:");
            int studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Surname:");
            string studentSurname = Console.ReadLine();

            Console.WriteLine("Enter Student Email:");
            string studentEmail = Console.ReadLine();

            // Create and return the student object
            Student student = new Student
            {
                StudentID = studentID,
                StudentName = studentName,
                StudentSurname = studentSurname,
                StudentEmail = studentEmail
            };

            return student;
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
                // Display the menu
                Console.WriteLine("---------------------------");
                Console.WriteLine("Student Registration System");
                Console.WriteLine("1 - Register Student");
                Console.WriteLine("2 - Exit");

                // Get user input
                Console.Write("Please enter your choice: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    // Register a new student
                    Student student = RegisterStudent();
                    Console.WriteLine($"Student Registered: {student.StudentName} {student.StudentSurname}");
                }
                else if (userChoice == "2" || userChoice.Equals("exit", StringComparison.OrdinalIgnoreCase))
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

            Console.ReadLine();
        }
    }
}
