using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Contracts.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
