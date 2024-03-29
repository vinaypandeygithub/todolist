#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0f7ce9060aae55b2d6cfbcd50dfb21022aeb36"
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
#nullable restore
#line 20 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
using ToDo.Models;

#line default
#line hidden
#nullable disable
    public partial class StoryList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "story-status");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
         ListStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " (");
            __builder.AddContent(6, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                      Stories.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "dropzone" + " " + (
#nullable restore
#line 4 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                         dropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ondragover", "event.preventDefault();");
            __builder.AddAttribute(12, "ondragstart", "event.dataTransfer.setData(\'\', event.target.id);");
            __builder.AddAttribute(13, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                 HandleDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                      HandleDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragleave", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                      HandleDragLeave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
         foreach (var story in Stories)
        { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "Story");
            __builder.AddAttribute(19, "StoryModel", "story");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 14 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor"
                       
    [CascadingParameter] StoryContainer Container { get; set; }
    [Parameter] public StoryStatuses ListStatus { get; set; }
    [Parameter] public StoryStatuses[] AllowedStatuses { get; set; }

    List<ToDo.Models.Story> Stories = new List<ToDo.Models.Story>();
    string dropClass = "";

    protected override void OnParametersSet()
    {
        Stories.Clear();
        Stories.AddRange(Container.Stories.Where(x => x.Status == ListStatus));
    }

    private void HandleDragEnter()
    {
        if (ListStatus == Container.Payload.Status) return;

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status))
        {
            dropClass = "no-drop";
        }
        else
        {
            dropClass = "can-drop";
        }
    }

    private void HandleDragLeave()
    {
        dropClass = "";
    }

    private async Task HandleDrop()
    {
        dropClass = "";

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

        await Container.UpdateStoryAsync(ListStatus);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
