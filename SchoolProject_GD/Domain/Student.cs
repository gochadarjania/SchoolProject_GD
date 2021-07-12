using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolProject_GD.Domain
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Subject Name must be 50 characters or less"), MinLength(5)]
        public string StudentName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Subject Name must be 50 characters or less"), MinLength(5)]
        public string StudentLastName { get; set; }

        [Required]
        public int StudentPersonalId { get; set; }

        [Required]
        [Range(18, 40, ErrorMessage = "Enter a value between 18 and 40")]
        public int StudentAge { get; set; }

        [Required]
        public Gender StudentGender { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
