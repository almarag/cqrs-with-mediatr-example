using System.ComponentModel.DataAnnotations;

namespace StudentsMicroService.Infrastructure.Entities
{
    public class AcademicData
    {
        [Key]
        public int StudentId { get; set; }
        public int Grade { get; set; }
    }
}