using Core.Models.Interface;

namespace Core.Models.Repository
{
    public class CarrierRepository:BaseRepository<int,Carrier>,ICarrier
    {
        public CarrierRepository(string userName):base(userName)
        {

        }
    }
}
