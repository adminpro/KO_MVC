using Core.Models.Interface;

namespace Core.Models.Repository
{
    public class CarrierRepository:BaseRepository<int,Carrier>,ICarrier<int>
    {
        public CarrierRepository(string userName):base(userName)
        {

        }

        public Carrier GetCarrier(int key)
        {
            return base.GetById(key);
        }

        public bool ExistsCarrier(Carrier carrier)
        {
            return base.Exists(carrier.CarrierId);
        }
    }
}
