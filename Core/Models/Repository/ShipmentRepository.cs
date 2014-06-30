﻿using Core.Models.Interface;

namespace Core.Models.Repository
{
    public class ShipmentRepository:BaseRepository<int, Shipment>, IShipment<int>
    {
        public ShipmentRepository(string userName):base(userName)
        {

        }
    }
}
