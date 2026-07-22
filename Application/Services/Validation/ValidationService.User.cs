using Application.Entities;
using Application.Services.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.Validation
{
    public partial class ValidationService
    {
        public static List<string> Validation(User user)
        {
            StorageService storageService = new StorageService();

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(user.FirstName))
            {
                errors.Add("فیلد نام اجباری است.");
            }

            if (string.IsNullOrEmpty(user.UserName))
            {
                errors.Add("نام کاربری اجباری است.");
            }else if(storageService?.Where(us => us.UserName == user.UserName).Count > 0)
            {
                errors.Add("نام کاربری قبلا انتخاب شده است.");
            }

            if (string.IsNullOrEmpty(user.Password) || user.Password.Length < 3)
            {
                errors.Add("رمز عبور باید حداقل ۳ کاراکتر باشد.");
            }

            return errors;
        }
    }
}
