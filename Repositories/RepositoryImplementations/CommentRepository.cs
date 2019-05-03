using Domain;
namespace Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}