using SMS.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Models;

public class CourseVM
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int LecturerId { get; set; }
    public string? Lecturer { get; set; }
}
