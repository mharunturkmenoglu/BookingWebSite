using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using BookingWebSite.Services.Abstract;

namespace BookingWebSite.Services.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCompany(Company company)
        {
            await _unitOfWork.Companies.AddAsync(company);
        }

        public async Task<ICollection<Company>> GetAllCompanies()
        {
            return await _unitOfWork.Companies.GetAllAsync();
        }

        public async Task<Company> GetCompany(int id)
        {
            return await _unitOfWork.Companies.GetAsync(x => x.Id == id);
        }

        public async Task RemoveCompany(int id)
        {
            var company = await _unitOfWork.Companies.GetAsync(x => x.Id == id);
            await _unitOfWork.Companies.DeleteAsync(company);
        }

        public async Task UpdateCompany(Company company, int id)
        {
            var updateCompany = await _unitOfWork.Companies.GetAsync(x => x.Id == id);
            if (updateCompany != null)
            {
                company.Id = updateCompany.Id;
                await _unitOfWork.Companies.UpdateAsync(company);
            }
        }
    }
}
