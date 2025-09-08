using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Contracts.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    
    Task<Employee?> GetEmployeeByIdAsync(int employeeId);
}