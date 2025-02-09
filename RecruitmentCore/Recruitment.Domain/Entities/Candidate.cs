
using Microsoft.Extensions.Hosting;

namespace Recruitment.Domain.Entities
{
    public class Candidate
    {
        public Guid CandidateID { get; set; }
        public string? Fistname { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Resume { get; set; }
        public string? Profile { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
