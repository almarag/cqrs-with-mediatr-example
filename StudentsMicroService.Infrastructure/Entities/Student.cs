using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsMicroService.Infrastructure.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("StudentId")]
        public virtual PersonalData PersonalData { get; set; }
        public virtual AcademicData AcademicData { get; set; }
    }
}
