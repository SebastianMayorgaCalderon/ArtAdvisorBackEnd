using Domain;
namespace Repositories
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
    }
}