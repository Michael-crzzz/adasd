namespace WebApplication1.Models.Entities
{
    public class BStudent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public bool Enrolled { get; set; }

    }
}
