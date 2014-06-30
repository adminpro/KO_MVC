using System.Collections.Generic;
namespace Core.Models.Interface
{
    public interface ITrackingMap<Key>
    {
        List<TrackingMap> GetByCarrierCode(string carrierCode);
    }
}
