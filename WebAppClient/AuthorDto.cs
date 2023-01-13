using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WebAppClient
{
    internal class AuthorDto
    { 
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateFormat? BirthDate { get; set; }
    public Gender Gender { get; set; }

}

public enum Gender
{
    Male,
    Female,
    Other
}
}
