﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BestStudentCafedra.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            AssignedStaffs = new HashSet<AssignedStaff>();
            SchedulePlans = new HashSet<SchedulePlan>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [RegularExpression(@"^[А-Я][а-я]+\s+[А-Я|а-я][а-я]+(\s+[А-Я|а-я][а-я]+)*$", ErrorMessage = "Имя должно состоять минимум из двух слов по две буквы")]
        [Display(Name = "Имя")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Не указана должность")]
        [StringLength(100, ErrorMessage = "Должность должна содержать менее 100 символов")]
        [Display(Name = "Должность")]
        public string Post { get; set; }
        [Display(Name = "Ученая степень")]
        public string AcademicDegree { get; set; }

        public virtual ICollection<AssignedStaff> AssignedStaffs { get; set; }
        public virtual ICollection<SchedulePlan> SchedulePlans { get; set; }
    }
}
