﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInstall
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public int NumPets { get; set; }
    }
}
