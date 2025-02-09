using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(RecruitmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
