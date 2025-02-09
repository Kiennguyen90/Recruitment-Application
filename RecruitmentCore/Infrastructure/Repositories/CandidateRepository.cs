using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(RecruitmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
