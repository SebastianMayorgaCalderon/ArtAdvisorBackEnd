namespace Repositories
{
    public interface IRepositoryWrapper
    {
        IArtAdvisorUserRepository Users { get; }
        ICategoryRepository Categories { get; }
        IMuseumRepository Museums { get; }
        ICommentRepository Comments { get; }
        IArtistRepository Artists { get; }
        IPricesRepository Prices { get; }
    }
}