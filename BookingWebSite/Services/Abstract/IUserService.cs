using BookingWebSite.Entities.Concrete;

namespace BookingWebSite.Services.Abstract
{
    public interface IUserService
    {
        Task<ICollection<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task AddUser(User user);
        Task UpdateUser(User user, int id);
        Task RemoveUser(int id);
    }
}
