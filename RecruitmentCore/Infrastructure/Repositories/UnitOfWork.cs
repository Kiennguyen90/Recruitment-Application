using Microsoft.EntityFrameworkCore;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;

namespace Recruitment.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly RecruitmentDbContext _dbContext;
        ILogger _logger;
        private string _errorMessage = string.Empty;
        private bool _disposed;

        IApplicationRepository _applicationRepository;
        ICandidateRepository _candidateRepository;
        IEmployerRepository _employerRepository;
        IFeedbackRepository _feedbackRepository;
        IJobRepository _jobRepository;

        public IApplicationRepository ApplicationRepository
        {
            get { return _applicationRepository = _applicationRepository ?? new ApplicationRepository(_dbContext); }
        }

        public ICandidateRepository CandidateRepository
        {
            get { return _candidateRepository = _candidateRepository ?? new CandidateRepository(_dbContext); }
        }

        public IEmployerRepository EmployerRepository 
        {
            get { return _employerRepository =  _employerRepository ?? new EmployerRepository(_dbContext); }
        }

        public IFeedbackRepository FeedbackRepository
        {
            get { return _feedbackRepository = _feedbackRepository ?? new FeedbackRepository(_dbContext); }
        }
        public IJobRepository JobRepository
        {
            get { return _jobRepository = _jobRepository ?? new JobRepository(_dbContext); }
        }

        public UnitOfWork(RecruitmentDbContext dbcontext, ILogger<UnitOfWork> logger)
        {
            _dbContext = dbcontext;
            _logger = logger;
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _dbContext.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            await _dbContext.Database.RollbackTransactionAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
