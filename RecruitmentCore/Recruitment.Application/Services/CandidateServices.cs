using Recruitment.Application.Interfaces;
using Recruitment.Application.Mappers.DTOs;
using Recruitment.Domain.Entities;

namespace Recruitment.Application.Services
{
    public class CandidateServices : ICandidateServices
    {
        public Task<bool> AddCandidateAsync(JobRequest jobRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCandidateAsync(Guid jobId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetAllCandidateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetCandidateByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCandidateAsync(JobRequest jobRequest)
        {
            throw new NotImplementedException();
        }
    }
}
