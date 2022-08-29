using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using BookingWebSite.Services.Abstract;

namespace BookingWebSite.Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task AddUser(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
        }

        public async Task<ICollection<User>> GetAllUsers()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _unitOfWork.Users.GetAsync(x => x.Id == id);
        }

        public async Task RemoveUser(int id)
        {
            var user = await _unitOfWork.Users.GetAsync(x => x.Id == id);
            await _unitOfWork.Users.DeleteAsync(user);
        }

        public async Task UpdateUser(User user, int id)
        {
            var updateUser = await _unitOfWork.Users.GetAsync(x => x.Id == id);
            if (updateUser != null)
            {
                user.Id = updateUser.Id;
                await _unitOfWork.Users.UpdateAsync(user);
            }
        }
    }
}
