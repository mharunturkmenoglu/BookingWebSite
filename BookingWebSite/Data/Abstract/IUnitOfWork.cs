namespace BookingWebSite.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IApartmentRepository Appartments { get; }
        IBookingRepository Bookings { get; }
        ICompanyRepository Companies { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}
