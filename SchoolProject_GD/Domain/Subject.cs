using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolProject_GD.Domain
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Subject Name must be 50 characters or less"), MinLength(5)]
        public string SubjectName { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
