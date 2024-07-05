using Microsoft.JSInterop;

namespace BlazorApp1.Shared
{
    public static class MessagePrompts
    {       
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static ValueTask<bool> Alert(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("alert", message);
        }

        public static ValueTask<string> InputBox(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<string>("prompt", message);
        }
    }
}
