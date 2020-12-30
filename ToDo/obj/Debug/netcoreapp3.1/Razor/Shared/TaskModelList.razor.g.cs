#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181e00c2b939ae58d276a53cadfb02680df9acbb"
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
#line 20 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
using ToDo.Models;

#line default
#line hidden
#nullable disable
    public partial class TaskModelList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "story-status");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h5");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
         ListStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " (");
            __builder.AddContent(6, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                      Tasks.Count()

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
#line 4 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                         dropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ondragover", "event.preventDefault();");
            __builder.AddAttribute(12, "ondragstart", "event.dataTransfer.setData(\'\', event.target.id);");
            __builder.AddAttribute(13, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                 HandleDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                      HandleDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragleave", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                      HandleDragLeave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
         foreach (var task in Tasks)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenComponent<ToDo.Shared.TaskModel>(18);
            __builder.AddAttribute(19, "TasksModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.Tasks>(
#nullable restore
#line 14 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                                   task

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 15 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
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
#line 20 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModelList.razor"
                       
    [CascadingParameter] TaskModelContainer Container { get; set; }
    [Parameter] public TaskStatuses ListStatus { get; set; }
    [Parameter] public TaskStatuses[] AllowedStatuses { get; set; }

    List<Tasks> Tasks = new List<Tasks>();
    string dropClass = "";

    protected override void OnParametersSet()
    {
        Tasks.Clear();
        Tasks.AddRange(Container.Tasks.Where(x => x.Status == ListStatus));
    }

    private void HandleDragEnter()
    {
        if (Container.Payload==null || ListStatus == Container.Payload.Status) return;

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

    private void HandleDragStart(Task task)
    {
        dropClass = "";
    }


    private async Task HandleDrop()
    {
        dropClass = "";

        if (Container.Payload!=null && AllowedStatuses != null  && !AllowedStatuses.Contains(Container.Payload.Status)) return;

        await Container.UpdateTasksAsync(ListStatus);
        Container.Payload = null;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
