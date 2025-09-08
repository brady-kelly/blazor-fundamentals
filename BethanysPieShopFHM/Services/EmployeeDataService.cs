using BethanysPieShopFHM.Contracts.Repositories;
using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Contracts.Repositories;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Services;

public class EmployeeDataService: IEmployeeDataService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public EmployeeDataService(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
    {
        _employeeRepository = employeeRepository;
        _webHostEnvironment = webHostEnvironment;
        _httpContextAccessor = httpContextAccessor;
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
        if (employee.ImageContent is not null)
        {
            string currentUrl = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = @$"{_webHostEnvironment.WebRootPath}\uploads\{employee.ImageName}";
            var fileStream = File.Create(path);
            fileStream.Write(employee.ImageContent, 0, employee.ImageContent.Length);
            fileStream.Close();

            employee.ImageName = $"https://{currentUrl}/uploads/{employee.ImageName}";
        }

        await _employeeRepository.UpdateEmployee(employee);
    }

    public async Task DeleteEmployee(int employeeId)
    {
        await _employeeRepository.DeleteEmployee(employeeId);
    }
}