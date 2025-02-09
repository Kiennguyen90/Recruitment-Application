using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class EmployerRepository : GenericRepository<Employer>, IEmployerRepository
    {
        public EmployerRepository(RecruitmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
