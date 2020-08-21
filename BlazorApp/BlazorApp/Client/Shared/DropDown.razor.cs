using BlazorApp.Client.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Shared
{    
    public partial class DropDown : ComponentBase
    {
        [Parameter] public string Title { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private Dictionary<string, string> records;


        protected override async Task OnInitializedAsync()
        {
            records = new Dictionary<string, string>()
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
        }       
    }
}
