using System;
using System.Collections.Generic;
using System.IO;
using Application.Entities;

namespace Application.Services.Storage;

public partial class StorageService
{
    private void CheckUserFile()
    {
        if (!File.Exists("users.storage"))
            File.Create("users.storage").Close();
    }

    public void Insert(User user)
    {
        CheckUserFile();

        string[] data =
        {
            user.Id.ToString(),
            user.FirstName,
            user.LastName,
            user.UserName,
            user.Password,
            user.RoleId.ToString()
        };

        File.AppendAllText(
            "users.storage",
            string.Join("|", data) + Environment.NewLine
        );
    }

    public User? GetUser(Guid id)
    {
        CheckUserFile();

        string[] lines = File.ReadAllLines("users.storage");

        foreach (string line in lines)
        {
            string[] fields = line.Split('|');

            if (fields.Length < 6)
                continue;

            if (Guid.TryParse(fields[0], out Guid userId) &&
                userId == id)
            {
                if (!Guid.TryParse(fields[5], out Guid roleId))
                    continue;

                return new User
                {
                    Id = userId,
                    FirstName = fields[1],
                    LastName = fields[2],
                    UserName = fields[3],
                    Password = fields[4],
                    RoleId = roleId
                };
            }
        }

        return null;
    }

    public List<User> GetUsers()
    {
        CheckUserFile();

        string[] lines = File.ReadAllLines("users.storage");

        List<User> users = new List<User>();

        foreach (string line in lines)
        {
            string[] fields = line.Split('|');

            if (fields.Length < 6)
                continue;

            if (!Guid.TryParse(fields[0], out Guid id))
                continue;

            if (!Guid.TryParse(fields[5], out Guid roleId))
                continue;

            users.Add(new User
            {
                Id = id,
                FirstName = fields[1],
                LastName = fields[2],
                UserName = fields[3],
                Password = fields[4],
                RoleId = roleId
            });
        }

        return users;
    }

    public void DeleteUser(Guid id)
    {
        CheckUserFile();

        string[] lines = File.ReadAllLines("users.storage");

        List<string> updatedLines = new();

        foreach (string line in lines)
        {
            string[] fields = line.Split('|');

            if (fields.Length == 0)
                continue;

            if (Guid.TryParse(fields[0], out Guid userId) &&
                userId == id)
            {
                continue;
            }

            updatedLines.Add(line);
        }

        File.WriteAllLines(
            "users.storage",
            updatedLines
        );
    }
}
