using System.Linq;
using System.Collections.Generic;
using Core.Models.Interface;

namespace Core.Models.Repository
{
    public class TrackingMapRepository: BaseRepository<int,TrackingMap>, ITrackingMap
    {
        public TrackingMapRepository(string userName):base(userName)
        {

        }

        public List<TrackingMap> GetByCarrierCode(string carrierCode)
        {
            return base.Get(c => c.CarrierCode.Equals(carrierCode), null, string.Empty).ToList();
        }
    }
}
