namespace CourseManagement.Models;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string ClassName { get; set; }   // bv. "2MCT"
    public DateTime DateOfBirth { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name, string email, string className, DateTime dateOfBirth)
    {
        Name = name;
        Email = email;
        ClassName = className;
        DateOfBirth = dateOfBirth;
        Courses = new List<Course>();
    }

    // geeft true terug als het gelukt is, false als de student al ingeschreven was
    public bool AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            return false;
        }
        Courses.Add(course);
        return true;
    }

    // geeft true terug als het vak verwijderd is, false als de student het niet volgde
    public bool RemoveCourse(Course course)
    {
        return Courses.Remove(course);
    }

    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (Course course in Courses)
        {
            total += course.Price;
        }
        return total;
    }

    public override string ToString()
    {
        return $"{Name} ({ClassName}) - {Email} - geboren {DateOfBirth:dd/MM/yyyy}";
    }
}
