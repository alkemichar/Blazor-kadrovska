#pragma checksum "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bc842cfddc14def80871e3ced194651520d8ea1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorApp.Client.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 2 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\MainLayout.razor"
                        appState

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "sidebar");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<BlazorApp.Client.Shared.NavMenu>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "main");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "top-row px-4");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "span");
                __builder2.AddAttribute(17, "class", "mr-md-auto");
                __builder2.AddContent(18, 
#nullable restore
#line 9 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\MainLayout.razor"
                                      appState.PageTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "content px-4");
                __builder2.AddMarkupContent(24, "\r\n\r\n            ");
                __builder2.AddContent(25, 
#nullable restore
#line 15 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\MainLayout.razor"
      
    AppState appState = new AppState();

    public class AppState
    {
        public string PageTitle { get; set; } = "Dobrodošli";
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp.Client.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
