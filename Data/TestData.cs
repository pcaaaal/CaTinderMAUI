using CaTinder.Models;

namespace CaTinder.Data;

using System;
using System.Collections.Generic;

public static class TestData
{
    // Cat Data
    public static readonly List<Cat> Cats = new()
    {
        new Cat { Id = Guid.NewGuid(), Name = "Kira", Gender = Gender.Female },
        new Cat { Id = Guid.NewGuid(), Name = "Leo", Gender = Gender.Male },
        new Cat { Id = Guid.NewGuid(), Name = "Mila", Gender = Gender.Female },
        new Cat { Id = Guid.NewGuid(), Name = "Tiger", Gender = Gender.Male },
        new Cat { Id = Guid.NewGuid(), Name = "Whiskers", Gender = Gender.Male },
        new Cat { Id = Guid.NewGuid(), Name = "Luna", Gender = Gender.Female },
        new Cat { Id = Guid.NewGuid(), Name = "Shadow", Gender = Gender.Male },
        new Cat { Id = Guid.NewGuid(), Name = "Daisy", Gender = Gender.Female },
        new Cat { Id = Guid.NewGuid(), Name = "Oreo", Gender = Gender.Male },
        new Cat { Id = Guid.NewGuid(), Name = "Mittens", Gender = Gender.Female }
    };

    // User Data
    public static readonly List<User> Users = new()
    {
        new User { Id = Guid.NewGuid(), FullName = "Anna Frey", Surname = "Anna", Name = "Frey", Username = "its_anna98", Cats = new List<Guid> { Cats[0].Id }, ImageName = "pp1" },
        new User { Id = Guid.NewGuid(), FullName = "Max Müller", Surname = "Max", Name = "Müller", Username = "max_thecatlover", Cats = new List<Guid> { Cats[1].Id }, ImageName = "pp2" },
        new User { Id = Guid.NewGuid(), FullName = "Sophia Wagner", Surname = "Sophia", Name = "Wagner", Username = "sophia.purrs", Cats = new List<Guid> { Cats[2].Id }, ImageName = "pp3" },
    };

    // Chat Data
    public static readonly List<Chat> Chats = new()
    {
        new Chat { Id = Guid.NewGuid(), UserId = Users[0].Id, LastMessage = "See you later!", Timestamp = "10:45 AM", ImageName = "pp2" },
        new Chat { Id = Guid.NewGuid(), UserId = Users[1].Id, LastMessage = "Sure thing!", Timestamp = "Yesterday", ImageName = "pp3" },
    };

    // Settings Data
    public static readonly List<Setting> Settings = new()
    {
        new Setting { Title = "General", Color = "#5A9", ImageName = "star.fill.png" },
        new Setting { Title = "Notifications", Color = "#09F", ImageName = "bell.sqare.fill.png" },
    };
}
