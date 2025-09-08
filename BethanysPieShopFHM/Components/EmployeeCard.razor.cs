using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components;

public partial class EmployeeCard : ComponentBase
{
    [Parameter]
    public Employee? Employee { get; set; } = null;
    
    [Parameter]
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
}