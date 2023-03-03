using System.ComponentModel.DataAnnotations;

namespace StudentsMicroService.Infrastructure.Entities
{
    public class StudentState
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Action { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string Data { get; set; }
    }
}
