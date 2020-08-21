using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Helpers
{
    public static class IJSRuntimeExtensinMethods
    {
        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeAsync<Object>("my_function", message);
        }
    }
}
