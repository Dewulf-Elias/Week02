using CourseManagementLibrary.Models;

namespace CourseManagement;

public static class Menu
{
    public static void Show(List<Course> courses, List<Student> students)
    {
        string choice;
        do
        {
            Console.WriteLine("===== Student Management =====");
            Console.WriteLine("1. Show courses");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Create a course");
            Console.WriteLine("4. Create a student");
            Console.WriteLine("5. Add a course to a student");
            Console.WriteLine("6. Remove a course from a student");
            Console.WriteLine("7. Total price for a student");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");
            choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ShowCourses(courses);
                    break;
                case "2":
                    ShowStudents(students);
                    break;
                case "3":
                    CreateCourse(courses);
                    break;
                case "4":
                    CreateStudent(students);
                    break;
                case "5":
                    AddCourseToStudent(courses, students);
                    break;
                case "6":
                    RemoveCourseFromStudent(students);
                    break;
                case "7":
                    ShowTotalPrice(students);
                    break;
                case "0":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine();
        } while (choice != "0");
    }

    private static void ShowCourses(List<Course> courses)
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
    }

    private static void ShowStudents(List<Student> students)
    {
        foreach (Student student in students)
        {
            Console.WriteLine(student);
            foreach (Course course in student.Courses)
            {
                Console.WriteLine($"   - {course.Name}");
            }
        }
    }

    private static void CreateCourse(List<Course> courses)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        int id = courses.Count + 1;
        courses.Add(new Course(id, name, price));
        Console.WriteLine("Course created.");
    }

    private static void CreateStudent(List<Student> students)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Email: ");
        string email = Console.ReadLine() ?? "";
        Console.Write("Class: ");
        string className = Console.ReadLine() ?? "";
        Console.Write("Date of birth (dd/mm/yyyy): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        students.Add(new Student(name, email, className, dateOfBirth));
        Console.WriteLine("Student created.");
    }

    private static void AddCourseToStudent(List<Course> courses, List<Student> students)
    {
        Student? student = ChooseStudent(students);
        if (student == null) return;

        Course? course = ChooseCourse(courses);
        if (course == null) return;

        if (student.AddCourse(course))
        {
            Console.WriteLine($"{student.Name} is now enrolled in {course.Name}.");
        }
        else
        {
            Console.WriteLine($"{student.Name} is already enrolled in {course.Name}.");
        }
    }

    private static void RemoveCourseFromStudent(List<Student> students)
    {
        Student? student = ChooseStudent(students);
        if (student == null) return;

        Course? course = ChooseCourse(student.Courses);
        if (course == null) return;

        student.RemoveCourse(course);
        Console.WriteLine($"{course.Name} removed from {student.Name}.");
    }

    private static void ShowTotalPrice(List<Student> students)
    {
        Student? student = ChooseStudent(students);
        if (student == null) return;

        Console.WriteLine($"Total price for {student.Name}: {student.TotalPrice()} euro");
    }

    // toont de studenten met een nummer en laat de gebruiker er één kiezen
    private static Student? ChooseStudent(List<Student> students)
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {students[i].Name}");
        }
        Console.Write("Choose a student: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= students.Count)
        {
            return students[number - 1];
        }
        Console.WriteLine("Invalid student.");
        return null;
    }

    // toont de vakken en laat de gebruiker er één kiezen via het Id
    private static Course? ChooseCourse(List<Course> courses)
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
        Console.Write("Choose a course (Id): ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            foreach (Course course in courses)
            {
                if (course.Id == id)
                {
                    return course;
                }
            }
        }
        Console.WriteLine("Invalid course.");
        return null;
    }
}
