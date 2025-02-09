using Recruitment.Application.Interfaces;
using Recruitment.Application.Mappers.DTOs;
using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;

namespace Recruitment.Application.Services
{
    public class JobServices : IJobServices
    {
        private IGenericRepository<Job> _repository;
        private ILogger _logger;
        public JobServices(IGenericRepository<Job> repository, ILogger<JobServices> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Job> GetJobByIdAsync(Guid Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<bool> AddJobAsync(JobRequest jobRequest)
        {
            try
            {
                Job job = new Job();
                var jobmapping = new JobMapping(job, jobRequest);
                jobmapping.DTOToDomain();

                await _repository.AddAsync(job);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Create Job Error ex: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateJobAsync(JobRequest jobRequest)
        {
            try
            {
                var jobUpdating = await _repository.GetByIdAsync(jobRequest.JobID);
                if (jobUpdating == null) 
                {
                    return false;
                }
                var jobmapping = new JobMapping(jobUpdating, jobRequest);
                jobmapping.DTOToDomain();
                await _repository.UpdateAsync(jobUpdating);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteJobAsync(Guid jobId)
        {
            try
            {
                await _repository.DeleteAsync(jobId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
