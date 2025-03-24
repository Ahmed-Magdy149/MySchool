
using Microsoft.AspNetCore.Components;
using MySchool.Shared.Services;

namespace MySchool.Shared.Pages
{
    public partial class Home : ComponentBase
    {
        private string factor => FormFactor.GetFormFactor();
        private string platform => FormFactor.GetPlatform();
    }
}
