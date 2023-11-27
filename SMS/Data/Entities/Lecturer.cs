using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Data.Entities;

public class Lecturer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string StaffNo { get; set; }
    public IEnumerable<Course> Courses { get; set; }
}
