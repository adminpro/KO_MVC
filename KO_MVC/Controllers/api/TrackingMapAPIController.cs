using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Models;
using Core.Models.Repository;

namespace KO_MVC.Controllers.api
{
    public class TrackingMapAPIController : ApiController
    {
        private TrackingMapRepository _trackingMapRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingMapAPIController"/> class.
        /// </summary>
        public TrackingMapAPIController()
        {
            if (_trackingMapRepository == null)
            {
                _trackingMapRepository = new TrackingMapRepository("ChienHM");
            }
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="skip">The skip.</param>
        /// <param name="take">The take.</param>
        /// <returns>List{TrackingMap}.</returns>
        public List<TrackingMap> GetAll(int skip, int take)
        {
            return _trackingMapRepository.GetPaging(null, c => c.OrderBy(a => a.TrackingMapId), string.Empty, skip * take, take).ToList();
        }

        /// <summary>
        /// Gets the by id.
        /// </summary>
        /// <param name="trackingMapId">The tracking map id.</param>
        /// <returns>TrackingMap.</returns>
        public TrackingMap GetById(int trackingMapId)
        {
            return _trackingMapRepository.GetById(trackingMapId);
        }

        /// <summary>
        /// Creates the specified tracking map.
        /// </summary>
        /// <param name="trackingMap">The tracking map.</param>
        /// <returns><c>true</c> if save success, <c>false</c> otherwise</returns>
        public bool Create(TrackingMap trackingMap)
        {
            _trackingMapRepository.Create(trackingMap);
            return _trackingMapRepository.SaveChanges();
        }

        /// <summary>
        /// Edits the specified tracking map id.
        /// </summary>
        /// <param name="trackingMapId">The tracking map id.</param>
        /// <param name="trackingMap">The tracking map.</param>
        /// <returns>TrackingMap.</returns>
        public TrackingMap Edit(int trackingMapId, TrackingMap trackingMap)
        {
            var existsTrackingMap = _trackingMapRepository.GetById(trackingMapId);
            if (existsTrackingMap!=null)
            {
                existsTrackingMap.CarrierId = trackingMap.CarrierId;
                existsTrackingMap.EswCode = trackingMap.EswCode;
                existsTrackingMap.CarrierCode = trackingMap.CarrierCode;
                existsTrackingMap.Description = trackingMap.Description;
            }
            if (_trackingMapRepository.SaveChanges())
                return trackingMap;
            return null;
        }

        /// <summary>
        /// Deletes the specified tracking map id.
        /// </summary>
        /// <param name="trackingMapId">The tracking map id.</param>
        /// <returns><c>true</c> if exists entity in db, <c>false</c> otherwise</returns>
        public bool Delete(int trackingMapId)
        {
            var existsTrackingMap = _trackingMapRepository.GetById(trackingMapId);
            if (existsTrackingMap != null)
            {
                _trackingMapRepository.Delete(existsTrackingMap);
                return _trackingMapRepository.SaveChanges();
            }
            return false;
        }
    }
}
