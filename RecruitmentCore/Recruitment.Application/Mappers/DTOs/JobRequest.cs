using Recruitment.Domain.Entities;

namespace Recruitment.Application.Mappers.DTOs
{
    public class JobRequest
    {
        public Guid JobID { get; set; }
        public string? JobTitle { get; set; }
        public string? Description { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public string? SalaryRange { get; set; }
    }

    public class JobMapping
    {
        private Job _job;
        private JobRequest _jobDTOs;
        public JobMapping(Job job, JobRequest jobRequest) 
        {
            _job = job;
            _jobDTOs = jobRequest;
        }
        public void DTOToDomain()
        {
            _job.JobID = _jobDTOs.JobID;
            _job.JobTitle = _jobDTOs.JobTitle;
            _job.Description = _jobDTOs.Description;
            _job.Department = _jobDTOs.Department;
            _job.Location = _jobDTOs.Location;
            _job.SalaryRange = _jobDTOs.SalaryRange;
            _job.DatePosted = DateTime.UtcNow;
        }
    }
}
