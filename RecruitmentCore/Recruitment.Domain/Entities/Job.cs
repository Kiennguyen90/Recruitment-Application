using System.ComponentModel.DataAnnotations;

namespace Recruitment.Domain.Entities
{
    public class Job
    {
        [Key]
        public Guid JobID { get; set; }
        public string? JobTitle { get; set; }
        public string? Description { get; set; }
        public string? Department {  get; set; }
        public string? Location { get; set; }
        public string? SalaryRange { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.UtcNow;

        public ICollection<Application> Applications { get; set; }
    }
}
