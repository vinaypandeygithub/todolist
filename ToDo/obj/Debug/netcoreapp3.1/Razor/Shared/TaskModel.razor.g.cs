#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a19a258c6262d775d25fce600be04ae8c9025b2"
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
            __builder.AddAttribute(5, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                                                                                                                         HandleDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                                                                                                                                                    HandleDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "class", "description");
            __builder.AddContent(10, 
#nullable restore
#line 3 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                            TasksModel.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "last-updated");
            __builder.AddMarkupContent(14, "<small>Last Updated</small> ");
            __builder.AddContent(15, 
#nullable restore
#line 4 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
                                                         TasksModel.LastUpdated.ToString("HH:mm.ss tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Shared\TaskModel.razor"
       
    [CascadingParameter] TaskModelContainer Container { get; set; }
    [Parameter] public Tasks TasksModel { get; set; }
    int sourceTaskStoryID;
    TaskStatuses originalTaskStatus;
    int currentTaskIndex;
    private void HandleDragStart(Tasks selectedTask)
    {
        sourceTaskStoryID = selectedTask.StoryId;
        originalTaskStatus = selectedTask.Status;
        currentTaskIndex = GetIndex(selectedTask);
        Container.Payload = selectedTask;
    }
    private void HandleDragEnter()
    {
        if (Container.Payload == null) return;
        if (TasksModel.StoryId != Container.Payload.StoryId)
        {
            return;
        }

    }
    int GetIndex(Tasks item)
    {
        return Container.Tasks.FindIndex(a => a.Id == item.Id);
    }
    void ClickItem(Tasks tasks)
    {
        sourceTaskStoryID = tasks.StoryId;
        originalTaskStatus = tasks.Status;
        currentTaskIndex = GetIndex(tasks);
    }
    private async Task HandleDrop()
    {
        if (Container.Payload == null )
        {
            return;
        }
        Tasks tasks = Container.Payload;
        if (originalTaskStatus == tasks.Status)
        {

            if (tasks != null)
            {
                var index = GetIndex(tasks);
                Console.WriteLine($"Drop index is {index}, move from {currentTaskIndex}");
                // get current item
                var current = Container.Tasks[currentTaskIndex];
                // remove game from current index
                Container.Tasks.RemoveAt(currentTaskIndex);
                Container.Tasks.Insert(index, current);
                await Container.StatusChanged();

            }
        }
        Container.Payload = null;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591