#pragma checksum "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c96a7747e6781bedcd9d58865bc730a59316ea0"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
             for (int i = 0; i < FetchData.LOOP; ++i){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
                 foreach (var forecast in forecasts)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenComponent<Test_Speed.Shared.TestARow>(12);
            __builder.AddAttribute(13, "forecast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Test_Speed.Pages.FetchData.WeatherForecast>(
#nullable restore
#line 29 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
                                         forecast

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 30 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "           \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 35 "/Users/daviderusso1984/Desktop/Test_Speed/Test_Speed/Pages/FetchData2.razor"
}

#line default
#line hidden
#nullable disable
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