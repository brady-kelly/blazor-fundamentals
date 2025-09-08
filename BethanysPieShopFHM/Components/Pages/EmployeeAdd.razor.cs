using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopFHM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeAdd : ComponentBase
{
    [SupplyParameterFromForm]
    public Employee? Employee { get; set; }
    
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    protected override void OnInitialized()
    {
        Employee ??= new Employee();
    }

    private async Task OnSubmit()
    {
        await EmployeeDataService.AddEmployee(Employee);
    }
}