#pragma checksum "C:\aplikacije\BlazorApp\BlazorApp\Client\Pages\Djelatnik\DjelatnikGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b274605ba3249900432ff40c9dca0a66921f20"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Client.Pages.Djelatnik
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\aplikacije\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\aplikacije\BlazorApp\BlazorApp\Client\Pages\Djelatnik\DjelatnikGrid.razor"
using Rhetos.Mvc.Kadrovska;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/djelatnici")]
    public partial class DjelatnikGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\aplikacije\BlazorApp\BlazorApp\Client\Pages\Djelatnik\DjelatnikGrid.razor"
      
    private List<string> djelatnikColumns;
    private List<Djelatnik> djelatnici;

    public DjelatnikGrid()
    {
        djelatnikColumns = new List<string>()
        {
            Rhetos.Mvc.Kadrovska.Djelatnik.PropertyMaticniBroj,
            Rhetos.Mvc.Kadrovska.Djelatnik.PropertyPrezime,
            Rhetos.Mvc.Kadrovska.Djelatnik.PropertyIme
        };
    }

    protected override async Task OnInitializedAsync()
    {
        
        djelatnici = await js.InvokeAsync<List<Djelatnik>>("GetItems", "Kadrovska", "Djelatnik");
        /*try
        {
            djelatnici = await djelatnikRepository.GetDjelatnici();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }*/
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
