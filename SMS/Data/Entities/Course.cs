using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Data.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Student> Students { get; set; } = Enumerable.Empty<Student>();
    public int LecturerId { get; set; }
    [ForeignKey(nameof(LecturerId))]
    public Lecturer Lecturer { get; set; }
}
