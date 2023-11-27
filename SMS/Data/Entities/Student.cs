using System.ComponentModel.DataAnnotations;

namespace SMS.Data.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RegNo { get; set; }
    public string Email { get; set; }
    public IEnumerable<Course> Courses { get; set; }
}
