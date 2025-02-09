namespace Recruitment.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IApplicationRepository ApplicationRepository { get; }
        ICandidateRepository CandidateRepository { get; }
        IEmployerRepository EmployerRepository { get; }
        IFeedbackRepository FeedbackRepository { get; }
        IJobRepository JobRepository { get; }

        Task<int> CompleteAsync(); // Save changes
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
