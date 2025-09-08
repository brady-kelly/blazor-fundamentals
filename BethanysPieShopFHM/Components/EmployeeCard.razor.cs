using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components;

public partial class EmployeeCard : ComponentBase
{
    [Parameter]
    public Employee? Employee { get; set; } = null;
    
    [Parameter]
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(Employee!.LastName))
        {
            throw new Exception("Employee lastname is empty");
        }
    }
}