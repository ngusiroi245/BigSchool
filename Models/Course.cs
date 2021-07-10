﻿namespace BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="LecturerId không được để trống!")]
        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required(ErrorMessage = "Place không được để trống!")]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public int CategoryId { get; set; }

        public string Name;

        public List<Category> ListCategory = new List<Category>();
    }
}
