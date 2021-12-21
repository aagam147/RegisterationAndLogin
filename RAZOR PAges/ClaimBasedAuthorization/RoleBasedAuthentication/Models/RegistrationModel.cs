﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Models
{
    [Table("Registration", Schema = "public")]
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}