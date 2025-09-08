using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components;

public partial class QuickViewPopup : ComponentBase
{
    [Parameter]
    public Employee? Employee { get; set; } 
    
    private Employee? _employee;
}