#pragma checksum "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Pages\RollHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2987d142b0e318864b506d6b38b7af87753a44b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_app_01.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using blazor_app_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using blazor_app_01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rollhistory")]
    public partial class RollHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Pages\RollHistory.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
