#pragma checksum "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c83b3245f164e20047e7585e26cc0b02a244483e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "c:\Users\G4NTZ\Documents\GitHub\PRT585-GROUP-F\Serkan-s329315\Week1\Blazor-HelloWorldApp\BlazorApp\Pages\Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 2;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
