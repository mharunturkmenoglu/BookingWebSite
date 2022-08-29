using BookingWebSite.Entities.Concrete;

namespace BookingWebSite.Services.Abstract
{
    public interface IApartmentService
    {
        Task<ICollection<Apartment>> GetAllAppartments();
        Task<Apartment> GetAppartment(int id);
        Task AddAppartment(Apartment appartment);
        Task UpdateAppartment(Apartment appartment, int id);
        Task RemoveAppartment(int id);
    }
}
