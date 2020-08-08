#pragma checksum "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c96a7747e6781bedcd9d58865bc730a59316ea0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test_Speed.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Test_Speed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/_Imports.razor"
using Test_Speed.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata2")]
    public partial class FetchData2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
       
    public Stopwatch sw = null;


    protected override void OnAfterRender (bool firstRender)
    {
        if (sw != null)
          {
            sw.Stop ();
            Console.WriteLine ("Forecast (component) = " + sw.ElapsedMilliseconds + " ms");
            sw = null;
          }
    }

    private FetchData.WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<FetchData.WeatherForecast[]>("sample-data/weather.json");
        if (forecasts != null)
            {
                sw = new Stopwatch ();
                sw.Start ();
            }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
