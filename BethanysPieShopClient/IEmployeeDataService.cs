using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Contracts.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    
    Task<Employee?> GetEmployeeById(int employeeId);

    Task<Employee> AddEmployee(Employee employee);

    Task UpdateEmployee(Employee employee);

    Task DeleteEmployee(int employeeId);
}