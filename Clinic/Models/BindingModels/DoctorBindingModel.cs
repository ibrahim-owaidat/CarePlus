﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models.BindingModels
{
    [BindProperties]
    public class DoctorBindingModel : UserCreationBindingModel
    {
        [Required]
        [MaxLength(256, ErrorMessage = "Max Length is 256 Chars")]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(256, ErrorMessage = "Max Length is 256 Chars")]
        public string Lastname { get; set; }

        [MaxLength(6, ErrorMessage = "Max length is 6")]
        public string Gender { get; set; }

        public string Specialty { get; set; }
    }
}
