using Recruitment.Application.Mappers.DTOs;
using Recruitment.Domain.Entities;

namespace Recruitment.Application.Interfaces
{
    public interface ICandidateServices
    {
        public Task<Job> GetCandidateByIdAsync(Guid Id);
        public Task<IEnumerable<Job>> GetAllCandidateAsync();
        public Task<bool> AddCandidateAsync(JobRequest jobRequest);
        public Task<bool> UpdateCandidateAsync(JobRequest jobRequest);
        public Task<bool> DeleteCandidateAsync(Guid jobId);
    }
}
