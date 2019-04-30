using Domain;
namespace Repositories
{
    public class MuseumReducer : RepositoryBase<Museum>, IMuseumRepository
    {
        public MuseumReducer(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}