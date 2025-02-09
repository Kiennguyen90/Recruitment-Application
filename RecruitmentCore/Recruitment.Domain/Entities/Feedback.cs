namespace Recruitment.Domain.Entities
{
    public class Feedback
    {
        public Guid FeedbackID { get; set; }
        public Guid ApplicationID { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string? Comments { get; set; }
        public int Rating { get; set; }

        public required Application Application { get; set; }
    }
}
