#pragma checksum "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestTemp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5f8efaf00b7c2760f7ba43a485b9fdadc543f99"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TestTemp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/daviderusso1984/Downloads/Test_Speed/Test_Speed/Shared/TestTemp.razor"
 
    public enum TUnit
    {
        NONE,
        fahrenheit
    }


    [Parameter] public int     Celsius  { get; set; } = 20;
    [Parameter] public TUnit   Convert  { get; set; } = TUnit.NONE;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
