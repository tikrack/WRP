using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.Validation
{
    public partial class ValidationService
    {
        public static List<string> Validation(User user)
        {
            List<string> errors = new List<string>();

            if(string.IsNullOrEmpty(user.UserName))
            {
                errors.Add("");
            }

            return errors;
        }
    }
}
