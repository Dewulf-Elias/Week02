namespace CourseManagement.Models;

public class Course
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public decimal Price { get; set; }   // prijs voor één semester

    public Course(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"[{Id}] {Name} - {Price} euro";
    }
}
