using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; }
    
    private Employee? _selectedEmployee;
    
    private string Title = "Employee Overview";
    
    [Inject]
    private IEmployeeDataService? _employeeDataService {  get; set; }

    protected override async Task OnInitializedAsync()
    {
        Employees = (await _employeeDataService.GetAllEmployees()).ToList();
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}