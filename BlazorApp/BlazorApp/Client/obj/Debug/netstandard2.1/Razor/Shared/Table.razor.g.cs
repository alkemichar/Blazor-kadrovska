#pragma checksum "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14f2a4ebb4be2554cf466d99cdbc3f1f9c36d6c"
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
#line 2 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
using Rhetos.Mvc.Kadrovska;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Table<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-light bg-light");
            __builder.AddMarkupContent(2, "       \r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "navbar-brand");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", 
#nullable restore
#line 9 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                      CreateLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "class", "btn btn-secondary btn-sm");
            __builder.AddAttribute(9, "role", "button");
            __builder.AddAttribute(10, "aria-pressed", "true");
            __builder.AddMarkupContent(11, "<i class=\"oi oi-plus\"></i>");
            __builder.AddMarkupContent(12, "<span style=\"margin-left:10px\">Novi djelatnik</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<form class=\"form-inline\">\r\n            <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n            <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Traži</button>\r\n        </form>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "thead");
            __builder.AddAttribute(21, "class", "thead-dark");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n            <th style=\"width:150px;\"></th>\r\n");
#nullable restore
#line 21 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
             foreach (var column in Columns)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                ");
            __builder.OpenElement(26, "th");
            __builder.AddAttribute(27, "scope", "col");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                                 langCont.Keys[GetDisplayName(column)]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 24 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 28 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
         if (records == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddMarkupContent(38, "<td style=\"width:100px;\">\r\n                </td>\r\n");
#nullable restore
#line 33 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                 foreach (var column in Columns)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                    ");
            __builder.AddMarkupContent(40, "<td>\r\n                        <span class=\"spinner-grow spinner-grow-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                    </td>\r\n");
#nullable restore
#line 38 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 40 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
             foreach (var record in records)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "width:150px;");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", 
#nullable restore
#line 47 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                                  String.Format("{0}{1}/{2}",InfoLink, record.GetType().GetProperty("ID").GetValue(record, null).ToString(),"true")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(52, "role", "button");
            __builder.AddAttribute(53, "aria-pressed", "true");
            __builder.AddMarkupContent(54, "<i class=\"oi oi-info\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "href", 
#nullable restore
#line 48 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                                  String.Format("{0}{1}",EditLink, record.GetType().GetProperty("ID").GetValue(record, null).ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(59, "role", "button");
            __builder.AddAttribute(60, "aria-pressed", "true");
            __builder.AddAttribute(61, "style", "margin-left:10px;");
            __builder.AddMarkupContent(62, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "href", 
#nullable restore
#line 49 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                                  String.Format("{0}{1}",EditLink, record.GetType().GetProperty("ID").GetValue(record, null).ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "class", "btn btn-outline-dark btn-sm");
            __builder.AddAttribute(67, "role", "button");
            __builder.AddAttribute(68, "aria-pressed", "true");
            __builder.AddAttribute(69, "style", "margin-left:10px;");
            __builder.AddMarkupContent(70, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 51 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                     foreach (var column in Columns)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                        ");
            __builder.OpenElement(74, "td");
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.AddContent(76, 
#nullable restore
#line 54 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                             record.GetType().GetProperty(column).GetValue(record, null)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 56 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 58 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\aplikacije\BlazorApp\BlazorApp\Client\Shared\Table.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AKSoftware.Localization.MultiLanguages.ILanguageContainerService langCont { get; set; }
    }
}
#pragma warning restore 1591
