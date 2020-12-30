#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1404becb1e83e4d9b10fea44017a8253fb629c0"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\P10503383\source\repos\ToDo\ToDo\_Imports.razor"
using ToDo.Shared;

#line default
#line hidden
#nullable disable
    public partial class StoryContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "story-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.ToDo.Shared.StoryContainer.TypeInference.CreateCascadingValue_0(__builder, 3, 4, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryContainer.razor"
                           this

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddContent(7, 
#nullable restore
#line 3 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryContainer.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryContainer.razor"
       

    [Parameter] public List<ToDo.Models.Story> Stories { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback<ToDo.Models.Story> OnStatusUpdated { get; set; }

    public ToDo.Models.Story Payload { get; set; }

    public async Task UpdateStoryAsync(ToDo.Models.StoryStatuses newStatus)
    {
        var story = Stories.SingleOrDefault(x => x.Id == Payload.Id);

        if (story != null)
        {
            story.Status = newStatus;
            story.LastUpdated = DateTime.Now;
            await OnStatusUpdated.InvokeAsync(Payload);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ToDo.Shared.StoryContainer
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
