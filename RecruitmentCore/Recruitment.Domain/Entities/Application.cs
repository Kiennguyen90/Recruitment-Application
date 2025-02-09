namespace Recruitment.Domain.Entities
{
    public class Application
    {
        public Guid ApplicationID { get; set; }
        public Guid CandidateID { get; set; }
        public Guid JobID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string? Status { get; set; }
        public DateTime InterviewDate { get; set; }

        public required Candidate Candidate {  get; set; }
        public required Job Job { get; set; }
        public ICollection <Feedback> Feedbacks { get; set; }
    }
}
