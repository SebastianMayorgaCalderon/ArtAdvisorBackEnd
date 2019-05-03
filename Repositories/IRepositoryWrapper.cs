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
        IScheduleRepository Schedules { get; }
        IArtPiecesRepository ArtPieces { get; }
        ITranslationsRepository Translations { get; }
        void Save ();
    }
}