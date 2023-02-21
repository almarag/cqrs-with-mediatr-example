namespace StudentsMicroService.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public PersonalData PersonalData { get; set; }
        public AcademicData AcademicData { get; set; }
    }
}
