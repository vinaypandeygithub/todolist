#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\StoryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0f7ce9060aae55b2d6cfbcd50dfb21022aeb36"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
