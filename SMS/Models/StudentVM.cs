using SMS.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models;

public class StudentVM
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string? RegNo { get; set; }
    [EmailAddress]
    public string Email { get; set; }
}
