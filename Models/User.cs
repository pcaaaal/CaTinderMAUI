namespace CaTinder.Models;

using System;
using System.Collections.Generic;

public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public List<Guid> Cats { get; set; }
    public string ImageName { get; set; }
}
