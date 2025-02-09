using Recruitment.Domain.Entities;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(RecruitmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
