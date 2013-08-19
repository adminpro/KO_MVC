using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Models.Repository
{
    public class TrackingMapRepository: BaseRepository<int,TrackingMap>
    {
        public TrackingMapRepository(string userName):base(userName)
        {

        }
    }
}
