using Domain;
namespace Repositories
{
    public class TranslationsRepository : RepositoryBase<Translation>, ITranslationsRepository
    {
        public TranslationsRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}