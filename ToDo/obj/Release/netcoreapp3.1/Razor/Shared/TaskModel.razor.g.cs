#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae88a15a2e80ab44255f2b9b01af53be9a6bd2c5"
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
#line 1 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
using ToDo.Models;

#line default
#line hidden
#nullable disable
    public partial class TaskModel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "draggable");
            __builder.AddAttribute(2, "draggable", "true");
            __builder.AddAttribute(3, "title", 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                               TasksModel.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                                                                       () => HandleDragStart(TasksModel)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "description");
            __builder.AddContent(8, 
#nullable restore
#line 3 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                            TasksModel.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "last-updated");
            __builder.AddMarkupContent(12, "<small>Last Updated</small> ");
            __builder.AddContent(13, 
#nullable restore
#line 4 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                                         TasksModel.LastUpdated.ToString("HH:mm.ss tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
       
    [CascadingParameter] TaskModelContainer Container { get; set; }
    [Parameter] public Tasks TasksModel { get; set; }

    private void HandleDragStart(Tasks selectedTask)
    {
        Container.Payload = selectedTask;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
