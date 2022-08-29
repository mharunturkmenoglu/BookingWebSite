using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using BookingWebSite.Services.Abstract;

namespace BookingWebSite.Services.Concrete
{
    public class ApartmentManager : IApartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApartmentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAppartment(Apartment appartment)
        {
            await _unitOfWork.Appartments.AddAsync(appartment);
        }

        public async Task<ICollection<Apartment>> GetAllAppartments()
        {
            return await _unitOfWork.Appartments.GetAllAsync();
        }

        public async Task<Apartment> GetAppartment(int id)
        {
            return await _unitOfWork.Appartments.GetAsync(x => x.Id == id);
        }

        public async Task RemoveAppartment(int id)
        {
            var appartment = await _unitOfWork.Appartments.GetAsync(x => x.Id == id);
            await _unitOfWork.Appartments.DeleteAsync(appartment);
        }

        public async Task UpdateAppartment(Apartment appartment, int id)
        {
            var updateApartment = await _unitOfWork.Appartments.GetAsync(x => x.Id == id);
            if (updateApartment != null)
            {
                appartment.Id = updateApartment.Id;
                await _unitOfWork.Appartments.UpdateAsync(appartment);
            }
        }
    }
}
