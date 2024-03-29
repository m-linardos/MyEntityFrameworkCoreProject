﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEntityFrameworkCoreProject.Models {
    public class Student {

        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; }

        public Student() {
        }

    }
}
