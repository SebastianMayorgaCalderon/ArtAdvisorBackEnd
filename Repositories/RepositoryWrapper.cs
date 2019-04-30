using Domain;
namespace Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ArtAdvisorContext _artAdvisorcontext;

        private IArtAdvisorUserRepository _users;
        private ICategoryRepository _categories;
        private IMuseumRepository _museums;
        private ICommentRepository _comments;
        private IArtistRepository _artists;
        private IPricesRepository _prices;

        public IArtistRepository Artists
        {
            get
            {
                if (_artists == null)
                {
                    _artists = new ArtistRepository(_artAdvisorcontext);
                }
                return _artists;
            }
        }
        public IPricesRepository Prices
        {
            get
            {
                if (_prices == null)
                {
                    _prices = new PriceRepository(_artAdvisorcontext);
                }
                return _prices;
            }
        }
        public ICommentRepository Comments
        {
            get
            {
                if (_comments == null)
                {
                    _comments = new CommentRepository(_artAdvisorcontext);
                }
                return _comments;
            }
        }
        public IArtAdvisorUserRepository Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new ArtAdvisorUserRepository(_artAdvisorcontext);
                }
                return _users;
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                if (_categories == null)
                {
                    _categories = new CategoryRepository(_artAdvisorcontext);
                }
                return _categories;
            }
        }
        public IMuseumRepository Museums
        {
            get
            {
                if (_museums == null)
                {
                    _museums = new MuseumReducer(_artAdvisorcontext);
                }
                return _museums;
            }
        }
        public RepositoryWrapper(ArtAdvisorContext artAdvisorcontext)
        {
            _artAdvisorcontext = artAdvisorcontext;
        }
    }
}