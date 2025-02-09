using Recruitment.Application.Mappers.DTOs;
using Recruitment.Domain.Entities;

namespace Recruitment.Application.Interfaces
{
    public interface IJobServices
    {
        public Task<Job> GetJobByIdAsync(Guid Id);
        public Task<IEnumerable<Job>> GetAllJobsAsync();
        public Task<bool> AddJobAsync(JobRequest jobRequest);
        public Task<bool> UpdateJobAsync(JobRequest jobRequest);
        public Task<bool> DeleteJobAsync(Guid jobId);
    }
}
