using Domain;
namespace Repositories
{
    public class ArtAdvisorUserRepository : RepositoryBase<ArtAdvisorUser>, IArtAdvisorUserRepository
    {
        public ArtAdvisorUserRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}