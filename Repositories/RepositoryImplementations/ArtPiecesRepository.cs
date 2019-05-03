using Domain;
namespace Repositories
{
    public class ArtPiecesRepository : RepositoryBase<ArtPiece>, IArtPiecesRepository
    {
        public ArtPiecesRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}