using Core.Models.Interface;

namespace Core.Models.Repository
{
    public class TrackingEventsRepository:BaseRepository<long, TrackingEvent>, ITrackingEvents
    {
        public TrackingEventsRepository(string userName):base(userName)
        {

        }
    }
}