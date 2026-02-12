namespace Console_Student_Class_01
{
    internal class Program
    {  
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

            foreach (var item in courses)
            {
                Console.WriteLine($"Course ID: {item.CourseID}, Course Name: {item.CourseName}, Course Code: {item.CourseCode}, Course Credit: {item.CourseCredit}");
            }

            Console.Read();
        }
    }
}
