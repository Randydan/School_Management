﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class LecturerDTO 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Status { get; set; } = null!;
        public string Course { get; set; } = null!;
        public int Salary { get; set; }
        public int DepartmentDescription { get; set; }
    }
}