using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Domain
{
    public class StudentSubject
    {
        [Key]
        public int StudentSubjectID { get; set; }

        [Required]
        public int StudentPersonalId { get; set; }

        [Range(0, 100, ErrorMessage = "Enter a value between 0 and 100")]
        public int? StudentPoint { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Subject Name must be 50 characters or less"), MinLength(5)]
        public string SubjectName { get; set; }

        public Student student { get; set; }
        public Subject subject { get; set; }


    }
}
