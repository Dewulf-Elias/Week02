using CourseManagement;
using CourseManagementLibrary.Models;

List<Course> courses = new List<Course>();
List<Student> students = new List<Student>();

// wat startgegevens, zodat je meteen kunt testen
courses.Add(new Course(1, "C# Programming", 250.00m));
courses.Add(new Course(2, "Web Development", 199.50m));
courses.Add(new Course(3, "Databases", 175.00m));

students.Add(new Student("Elias Dewulf", "elias.dewulf@student.howest.be", "2MCT", new DateTime(2005, 3, 14)));
students.Add(new Student("Lotte Peeters", "lotte.peeters@student.howest.be", "2MCT", new DateTime(2004, 11, 2)));

Menu.Show(courses, students);
