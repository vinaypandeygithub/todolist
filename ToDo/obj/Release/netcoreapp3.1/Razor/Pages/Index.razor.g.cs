#pragma checksum "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b71e1186d6e9b4d4df62f24c4822fc156e947f"
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
#line 18 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
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
            __builder.AddAttribute(1, "id", "accordion");
            __builder.AddAttribute(2, "class", "accordionChangeCss");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 5 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
     foreach (var story in Stories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
             story.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<ToDo.Shared.TaskModelContainer>(10);
            __builder.AddAttribute(11, "Tasks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ToDo.Models.Tasks>>(
#nullable restore
#line 9 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                       story.Tasks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnStatusUpdated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ToDo.Models.Tasks>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ToDo.Models.Tasks>(this, 
#nullable restore
#line 9 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                     HandleStatusUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<ToDo.Shared.TaskModelList>(15);
                __builder2.AddAttribute(16, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses>(
#nullable restore
#line 10 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                           TaskStatuses.Todo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses[]>(
#nullable restore
#line 10 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                 new TaskStatuses[] { TaskStatuses.Done}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<ToDo.Shared.TaskModelList>(19);
                __builder2.AddAttribute(20, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses>(
#nullable restore
#line 11 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                           TaskStatuses.Done

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ToDo.Models.TaskStatuses[]>(
#nullable restore
#line 11 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                                                                                 new TaskStatuses[] { TaskStatuses.Todo}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 14 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\P10503383\source\repos\ToDo\ToDo\Pages\Index.razor"
                           
    List<ToDo.Models.Story> Stories = new List<ToDo.Models.Story>();
    string lastUpdatedStory = "";
    protected override void OnInitialized()
    {
    }
    protected override async Task OnInitializedAsync() {
        Stories =  await GetJsonAsync<List<Story>>("http://storiesandtaskmanagerapi.azurewebsites.net/api/tasks");

    }
    void HandleStatusUpdated(Tasks updatedJob)
    {
        lastUpdatedStory = updatedJob.Description;
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


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
