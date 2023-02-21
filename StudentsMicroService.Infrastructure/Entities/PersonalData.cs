using System.ComponentModel.DataAnnotations;

namespace StudentsMicroService.Infrastructure.Entities
{
    public class PersonalData
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}