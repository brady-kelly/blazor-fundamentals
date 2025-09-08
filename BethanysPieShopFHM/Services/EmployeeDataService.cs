using BethanysPieShopFHM.Contracts.Repositories;
using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Services;

public class EmployeeDataService: IEmployeeDataService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeDataService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await _employeeRepository.GetAllEmployeesAsync();
    }

    public async Task<Employee?> GetEmployeeByIdAsync(int employeeId)
    {
        return await _employeeRepository.GetEmployeeByIdAsync(employeeId);
    }
}