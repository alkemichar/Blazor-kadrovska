using Common;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Rhetos.Mvc.Kadrovska;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp.Client.Shared
{
    public partial class Table<TItem> : ComponentBase
    {
        [Inject] IJSRuntime js { get; set; }        
        [Parameter] public string Namespace { get; set; }
        [Parameter] public string Entity { get; set; }
        [Parameter] public List<string> Columns { get; set; }
        [Parameter] public string InfoLink { get; set; }
        [Parameter] public string EditLink { get; set; }
        [Parameter] public string CreateLink { get; set; }
        [Parameter] public List<TItem> records { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Delay(1000);
            //records =  await js.InvokeAsync<List<TItem>>("GetItems", Namespace, Entity);
        }

        private static string GetDisplayName(string propertyname)
        {
            MemberInfo myprop = typeof(TItem).GetProperty(propertyname) as MemberInfo;
            var dd = myprop.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
            return dd?.Name ?? "";
        }        
    }
}
