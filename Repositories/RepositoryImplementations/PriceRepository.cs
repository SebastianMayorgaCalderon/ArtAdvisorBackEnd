using Domain;
namespace Repositories
{
    public class PriceRepository : RepositoryBase<Price>, IPricesRepository
    {
        public PriceRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}