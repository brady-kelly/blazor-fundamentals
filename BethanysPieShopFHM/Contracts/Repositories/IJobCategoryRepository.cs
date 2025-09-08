using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Contracts.Repositories
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
