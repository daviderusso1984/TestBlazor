#pragma checksum "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3398736265318206ac1dcf9c784a5bfd84d5c91e"
// <auto-generated/>
#pragma warning disable 1591
namespace Test_Speed.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Test_Speed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/_Imports.razor"
using Test_Speed.Shared;

#line default
#line hidden
#nullable disable
    public partial class TestARow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
 if (forecast != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\r\n            ");
            __builder.OpenComponent<Test_Speed.Shared.TestDate>(3);
            __builder.AddAttribute(4, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 4 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                             forecast.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenComponent<Test_Speed.Shared.TestTemp>(6);
            __builder.AddAttribute(7, "Celsius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                                forecast.TemperatureC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Convert", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Test_Speed.Shared.TestTemp.TUnit>(
#nullable restore
#line 5 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                                                                TestTemp.TUnit.NONE

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Test_Speed.Shared.TestTemp>(10);
            __builder.AddAttribute(11, "Celsius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                                forecast.TemperatureC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Convert", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Test_Speed.Shared.TestTemp.TUnit>(
#nullable restore
#line 6 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                                                                TestTemp.TUnit.fahrenheit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenComponent<Test_Speed.Shared.TestText>(14);
            __builder.AddAttribute(15, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
                             forecast.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 9 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestARow.razor"
 
    [Parameter] public Pages.FetchData.WeatherForecast forecast { get; set; } = null;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
