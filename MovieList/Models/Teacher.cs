using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Models;

public class Teacher
{
    public int id { get; set; }
    public string? name { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateofBirth { get; set; }

    public string? Subject { get; set; }

    public string Address { get; set; }
}