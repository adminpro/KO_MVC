using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Models;

namespace KO_MVC.Controllers.api
{
    public class TrackingMapAPIController : ApiController
    {
        private CmsContext _context;
        public TrackingMapAPIController()
        {
            if (_context==null)
            {
                _context = new CmsContext();
            }
        }
        public List<TrackingMap> GetAll(int skip, int take)
        {
            return _context.TrackingMaps.OrderBy(c=>c.TrackingMapId).Skip(skip).Take(take).ToList();
        }
    }
}
