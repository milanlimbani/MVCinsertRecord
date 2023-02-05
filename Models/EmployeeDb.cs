using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class EmployeeDb
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
    }
}