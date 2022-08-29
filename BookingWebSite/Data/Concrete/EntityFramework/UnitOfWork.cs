using BookingWebSite.Data.Abstract;
using BookingWebSite.Data.Concrete.EntityFramework.Contexts;
using BookingWebSite.Data.Concrete.EntityFramework.Repositories;

namespace BookingWebSite.Data.Concrete.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private EfApartmentRepository _appartmentRepository;
        private EfBookingRepository _bookingRepository;
        private EfCompanyRepository _companyRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IApartmentRepository Appartments => _appartmentRepository ?? new EfApartmentRepository(_context);

        public IBookingRepository Bookings => _bookingRepository ?? new EfBookingRepository(_context);

        public ICompanyRepository Companies => _companyRepository ?? new EfCompanyRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
