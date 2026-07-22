using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.Storage
{
    public class CurrentUserStorage
    {
        public static User? User { get; set; }
    }
}
