using System.Collections.Generic;
namespace Core.Models.Interface
{
    public interface ITrackingMap
    {
        List<TrackingMap> GetByCarrierCode(string carrierCode);
    }
}
