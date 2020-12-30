
## What is the application for

The application is for managing day to day tasks, where user can create stories and related tasks.

Each task can be either in ToDo or Done State.

## Application Scope

Web interface that can display stories and related tasks, user will be able to drag and drop tasks from ToDo to Done and vice-versa.

## Out of scope

Interface and functionality to create stories/tasks, for purpose of this application data is hardcoded in API.

## Technology Stack

| **Component** | **Feature/Remark** |
| --- | --- |
| ASP.Net Blazor | Blazor is a feature of ASP.NET for building interactive web UIs using C# instead of JavaScript. |
| JQuery | Accordion view |
| Swagger | Simplify API development for users, teams, and enterprises with our open source and professional toolset |
| Web API | To exposes data to Blazor Application |
| MS Test | Unit Testing |


## Various Applications/Module

### POCO

This is a .Net Core Library project which holds all the POCO required for the application.

e.g:- Story/Task

### ToDoWeb Application

This module is a Asp.Net Blazor application which hold all the UI for application.

### ToDo API

This is web API for providing hardcoded data to the Asp.Net Blazor application.

#### api/tasks returns

[{&quot;id&quot;:1,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;House Work&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8277255+05:30&quot;,&quot;tasks&quot;:[{&quot;id&quot;:1,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Electricity Bill Payment&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8252314+05:30&quot;},{&quot;id&quot;:2,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Sainsbury Shopping&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8270291+05:30&quot;}]},{&quot;id&quot;:2,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Go to the gym&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8283158+05:30&quot;,&quot;tasks&quot;:[{&quot;id&quot;:1,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Biceps&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8283088+05:30&quot;},{&quot;id&quot;:2,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Triceps&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8283135+05:30&quot;},{&quot;id&quot;:3,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Rowing&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.828314+05:30&quot;},{&quot;id&quot;:4,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Cycling&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8283142+05:30&quot;},{&quot;id&quot;:5,&quot;status&quot;:0,&quot;title&quot;:null,&quot;description&quot;:&quot;Hiking&quot;,&quot;lastUpdated&quot;:&quot;2020-09-19T14:11:23.8283145+05:30&quot;}]}]

#### Swagger

This component is of great use when we are doing API documentation or just want to give a quick test to the API that we have created, a quick glance of it.

To access swagger you need to use [http://localhost:51567/swagger/index.html](http://localhost:51567/swagger/index.html) where your API is hosted at [http://localhost:51567](http://localhost:51567/).

### Unit Test

The solution has 1 unit test project which checks for web api to return hardcoded data.

This can be extended to include other test cases as well.

## NFR&#39;s Catered

1. Separate Web API created which can act as microservice hence can be scaled out.
2. Application has additional field like Story has Title/Description/Status/Last Updated of which Description/Status will cater for future development.

## Known Issues

Mobile view is not catered.

## How to Run In Visual Studio

Open VS 2019, open ToDo.sln and click run from tool bar or click F5, ToDo web application and ToDoAPI will both start.

If ToDo web application loads before ToDoAPI you may get an error, just wait for ToDOAPI to start and refresh ToDo application.
