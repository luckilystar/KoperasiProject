﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiProject.Domain.Users
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }

    }
}
