using System;
using System.Collections.Generic;
using System.Text;
using Application.Entities;

namespace Application.Services.Storage
{
    public partial class StorageService
    {
        private void CheckFile()
        {
            if (!File.Exists("roles.storage"))
                File.Create("roles.storage").Close();
        }

        public void Insert(Role role)
        {
            CheckFile();

            string[] data =
            {
                role.Id.ToString(),
                role.Name
            };

            File.AppendAllText(
                "roles.storage",
                string.Join("|", data) + Environment.NewLine
            );
        }

        public Role? GetRole(Guid id)
        {
            CheckFile();

            string[] lines = File.ReadAllLines("roles.storage");

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (Guid.TryParse(fields[0], out Guid roleId) &&
                    roleId == id)
                {
                    return new Role
                    {
                        Id = roleId,
                        Name = fields[1]
                    };
                }
            }

            return null;
        }

        public List<Role> GetRoles()
        {
            CheckFile();

            string[] lines = File.ReadAllLines("roles.storage");

            List<Role> roles = new();

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (!Guid.TryParse(fields[0], out Guid id))
                    continue;

                roles.Add(new Role
                {
                    Id = id,
                    Name = fields[1]
                });
            }

            return roles;
        }

        public void DeleteRole(Guid id)
        {
            CheckFile();

            string[] lines = File.ReadAllLines("roles.storage");

            List<string> updatedLines = new();

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (fields.Length == 0)
                    continue;

                if (Guid.TryParse(fields[0], out Guid roleId) &&
                    roleId == id)
                {
                    continue;
                }

                updatedLines.Add(line);
            }

            File.WriteAllLines(
                "roles.storage",
                updatedLines
            );
        }
    }
}