using BethanysPieShopFHM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    protected override void OnInitialized()
    {
        Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
    }
}