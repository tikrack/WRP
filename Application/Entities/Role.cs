using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public class Role
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;
    }
}
