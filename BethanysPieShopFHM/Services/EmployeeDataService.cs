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
    
    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await _employeeRepository.GetAllEmployees();
    }

    public async Task<Employee?> GetEmployeeById(int employeeId)
    {
        return await _employeeRepository.GetEmployeeById(employeeId);
    }

    public async Task<Employee> AddEmployee(Employee employee)
    {
        return await _employeeRepository.AddEmployee(employee);
    }

    public async Task UpdateEmployee(Employee employee)
    {
        await _employeeRepository.UpdateEmployee(employee);
    }

    public async Task DeleteEmployee(int employeeId)
    {
        await _employeeRepository.DeleteEmployee(employeeId);
    }
}