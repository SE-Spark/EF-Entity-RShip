namespace Entity_Rship.Data.Dto
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public ClassDto Class { get; set; }
    }
}
