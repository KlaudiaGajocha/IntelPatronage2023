using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WebApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateFormat? BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}

