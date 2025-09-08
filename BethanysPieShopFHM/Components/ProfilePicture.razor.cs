using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components;

public partial class ProfilePicture : ComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}