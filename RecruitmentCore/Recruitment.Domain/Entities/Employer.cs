namespace Recruitment.Domain.Entities
{
    public class Employer
    {
        public Guid EmployerID { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
