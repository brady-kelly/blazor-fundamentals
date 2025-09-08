using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Contracts.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    
    Task<Employee> GetEmployeeByIdAsync(int employeeId);
}