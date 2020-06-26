JSON Placeholder API Test

Introduction

The objective of this exercise is to test API’s endpoints for “posts” provided by JSON Placeholder https://jsonplaceholder.typicode.com/

Available Resources 
· Posts https://jsonplaceholder.typicode.com/posts/1 
· Comments https://jsonplaceholder.typicode.com/comments/1 
· Albums https://jsonplaceholder.typicode.com/albums/1 
· Photos https://jsonplaceholder.typicode.com/photos/1 
· Users https://jsonplaceholder.typicode.com/users/1 
· Todos https://jsonplaceholder.typicode.com/todos/1

Note: resources have relations. For example: posts have many comments, albums have many photos, see below for routes examples.

Resources Under Test

GET /posts/1

GET /posts/1/comments Note: you can view detailed examples here.

-------------------------------------------------------------------------------------------

Dev Tools: Visual Studio 2019, https://visualstudio.microsoft.com/vs/
Specflow for Visual studio 2019	   https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio
Knowledge: https://github.com/reactiveui/refit
Nuget Packages: 
          Microsoft.Extensions.DependencyInjection – 3.15, 
          Refit 5.1.67
          Reffit.HttpClientFactory – 5.1.67
          System.Runtime.CompilerServices.Unsafe
          Microsoft.Extensions.Configuration (3.1.5)
          Microsoft.Extensions.DependencyInjection (3.1.5)
          NUnit3TestAdapter (3.16.1)
          SolidToken.SpecFlow.DependencyInjection (0.4.1)
          SpecFlow (3.1.97)
          SpecFlowNunit (3.1.97)
          SpecFlow.Tools.MsBuild.Generation (3.1.97)

