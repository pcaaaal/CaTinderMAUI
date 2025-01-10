namespace CaTinder.Models;

using System;

public enum Gender
{
    Male,
    Female
}

public class Cat
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
}