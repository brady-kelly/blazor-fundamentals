using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; } = new Employee();
    
    [Inject]
    private IEmployeeDataService? _employeeDataService {  get; set; }

    protected async override Task OnInitializedAsync()
    {
        Employee = await _employeeDataService.GetEmployeeByIdAsync(EmployeeId);
    }

    public void ChangeHoliday()
    {
        Employee.IsOnHoliday = !Employee.IsOnHoliday;
    }
}