#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf83dbedd6069b69dd7d06d5c9f5d2fc9f852ee6"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
using ToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "searchDivBar");
            __builder.AddMarkupContent(2, "\r\n   Search");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "text-xl-left");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                        TextForFilteration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TextForFilteration = __value, TextForFilteration));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(8, " ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn-primary");
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                                                     filterText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                                                                           filterText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Go");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
 foreach (var story in Stories)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "collapsiblecontainer");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "customcollapsible");
            __builder.AddAttribute(23, "draggable", "true");
            __builder.AddAttribute(24, "ondragover", "event.preventDefault();");
            __builder.AddAttribute(25, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                        ()=>HandleDrop(story)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                             ()=>HandleDragEnter(story)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                             ()=>ClickItem(story)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, 
#nullable restore
#line 13 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                     story.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "customcontent");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenComponent<ToDo.Shared.TaskModelContainer>(33);
            __builder.AddAttribute(34, "Tasks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ToDo.Models.Tasks>>(
#nullable restore
#line 16 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                       story.Tasks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnStatusUpdated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ToDo.Models.Tasks>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ToDo.Models.Tasks>(this, 
#nullable restore
#line 16 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                     HandleStatusUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<ToDo.Shared.TaskModelList>(38);
                __builder2.AddAttribute(39, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses>(
#nullable restore
#line 17 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                           TaskStatuses.Todo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses[]>(
#nullable restore
#line 17 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                 new TaskStatuses[] { TaskStatuses.Done, TaskStatuses.Todo}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenComponent<ToDo.Shared.TaskModelList>(42);
                __builder2.AddAttribute(43, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses>(
#nullable restore
#line 18 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                           TaskStatuses.Done

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses[]>(
#nullable restore
#line 18 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                 new TaskStatuses[] { TaskStatuses.Done, TaskStatuses.Todo}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 22 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                           
    List<ToDo.Models.Story> Stories = new List<ToDo.Models.Story>();
    List<ToDo.Models.Story> StoriesToPersist = new List<ToDo.Models.Story>();
    string lastUpdatedStory = "";
    int currentIndex;
    public string TextForFilteration { get; set; } = string.Empty;
    protected override void OnInitialized()
    {
    }
    protected override async Task OnInitializedAsync()
    {
        Stories = await GetJsonAsync<List<Story>>("http://localhost:51567/api/tasks");
        StoriesToPersist = Stories;
    }

    protected void filterText()
    {
        Stories = StoriesToPersist.Where(x => x.Description.ToLower().Contains(TextForFilteration.ToLower())).ToList();
        StateHasChanged();
    }

    void HandleStatusUpdated(Tasks updatedJob)
    {
        lastUpdatedStory = updatedJob.Description;
        StateHasChanged();
    }
    public async Task<T> GetJsonAsync<T>(string requestUri)
    {
        HttpClient httpClient = new HttpClient();
        var httpContent = await httpClient.GetAsync(requestUri);
        string jsonContent = httpContent.Content.ReadAsStringAsync().Result;
        T obj = JsonConvert.DeserializeObject<T>(jsonContent);
        httpContent.Dispose();
        httpClient.Dispose();
        return obj;
    }
    int GetIndex(Story item)
    {
        return Stories.FindIndex(a => a.Id == item.Id);
    }
    private void HandleDragEnter(Story story)
    {

    }
    void ClickItem(Story story)
    {
        currentIndex = GetIndex(story);
    }
    private async Task HandleDrop(Story story)
    {
        if (story != null)
        {
            var index = GetIndex(story);
            Console.WriteLine($"Drop index is {index}, move from {currentIndex}");
            // get current item
            var current = Stories[currentIndex];
            // remove game from current index
            Stories.RemoveAt(currentIndex);
            Stories.Insert(index, current);

            StateHasChanged();
        }
        else
        {

        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
