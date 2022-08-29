
using BookingWebSite.Entities.Concrete;

namespace BookingWebSite.Services.Abstract
{
    public interface ICompanyService
    {
        Task<ICollection<Company>> GetAllCompanies();
        Task<Company> GetCompany(int id);
        Task AddCompany(Company company);
        Task UpdateCompany(Company company, int id);
        Task RemoveCompany(int id);
    }
}