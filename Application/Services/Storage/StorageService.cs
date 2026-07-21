using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.Storage
{
    public partial class StorageService
    {
        private readonly string _storagePath = "storage";

        public StorageService()
        {
            if (!Directory.Exists(_storagePath))
                Directory.CreateDirectory(_storagePath);
        }
    }
}

