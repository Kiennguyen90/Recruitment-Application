using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(RecruitmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
