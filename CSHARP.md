## Understanding .NET
### Understanding .NET Framework

.NET Framework is a development platform that includes a `Common Language Runtime (CLR)`, which manages the execution of code, and a `Base Class Library (BCL)`, which provides a rich library of classes to build applications from.
Microsoft originally designed .NET Framework to have the possibility of being cross-platform, but Microsoft put their implementation effort into making it work best with Windows

All of the apps on a computer written for .NET Framework share the same version of the CLR and libraries stored in the `Global Assembly Cache (GAC)`, which can lead to issues if some of them need a specific version for compatibility

- `Good Practice`: Practically speaking, .NET Framework is Windows-only and a legacy platform. Do not create new apps using it

### Understanding the Mono and Xamarin projects

Third parties developed a .NET Framework implementation named the `Mono` project. Mono is cross-platform, but it fell well behind the official implementation of .NET Framework.

Mono has found a niche as the foundation of the `Xamarin` mobile platform as well as crossplatform game development platforms like `Unity`

Microsoft purchased Xamarin in 2016 and now gives away what used to be an expensive Xamarin extension for free with Visual Studio 2019. Microsoft renamed the `Xamarin Studio` development tool, which could only create mobile apps, to Visual Studio for Mac and gave it the ability to create other types of projects like console apps and web services.
With Visual Studio 2019 for Mac, Microsoft has replaced parts of the Xamarin Studio editor with parts from Visual Studio for Windows to provide closer parity of experience and performance

### Understanding .NET Core

Today, we live in a truly cross-platform world where modern mobile and cloud development have made Windows, as an operating system, much less important.
Because of that, Microsoft has been working on an effort to decouple .NET from its close ties with Windows. 
While rewriting .NET Framework to be truly cross-platform, they've taken the opportunity to refactor and remove major parts that are no longer considered core.

This new product was branded .NET Core and includes a cross-platform implementation of the CLR known as `CoreCLR` and a streamlined library of classes known as `CoreFX`

### Understanding .NET 5 and the journey to one .NET

At the Microsoft Build developer conference in May 2020, the .NET team announced that their plans for the unification of .NET had been delayed. They said .NET 5 would be released on November 10, 2020 and `it would unify all the various .NET platforms except mobile`. It will not be until .NET 6 in November 2021 that `mobile will also be supported by the unified .NET platform`.

.NET Core has been renamed .NET and the major version number has `skipped the number four` to `avoid confusion with .NET Framework 4.x`. Microsoft plans on annual major version releases every November, rather like Apple does major version number releases of iOS every September.

### What is different about .NET Core and .NET 5?

Modern .NET is smaller than the current version of .NET Framework due to the fact that `legacy and non-cross-platform technologies have been removed`.
For example, `Windows Forms` and `Windows Presentation Foundation (WPF)` can be used to build graphical user interface (GUI) applications, but they are `tightly bound to the Windows ecosystem`, so they have been removed from .NET on macOS and Linux

One of the features of .NET 5 is support for `running old Windows Forms and WPF applications` using the `Windows Desktop Pack` that is included with the Windows version of .NET 5, which is why it is bigger than the SDKs for macOS and Linux.

`ASP.NET Web Forms` and `Windows Communication Foundation (WCF)` are old web application and service technologies that fewer developers are choosing to use for new
development projects today, so they have also been removed from .NET 5.
Instead, developers prefer to use `ASP.NET MVC` and `ASP.NET Web API`. These two technologies have been refactored and combined into a platform that runs on .NET 5, named `ASP.NET Core`

`Entity Framework (EF) 6` is an object-relational mapping technology that is designed to work with data that is stored in relational databases such as Oracle and Microsoft SQL Server.
It has gained baggage over the years, so the cross-platform API has been slimmed down, has been given support for non-relational databases like Microsoft Azure Cosmos DB, and has been renamed `Entity Framework Core`

In addition to removing large pieces from .NET Framework in order to make .NET Core, Microsoft has `componentized .NET into NuGet packages`, those being small chunks of functionality that can be deployed independently

Microsoft's primary goal is not to make .NET smaller than .NET Framework. The goal is to `componentize .NET to support modern technologies and to have fewer dependencies`, so that `deployment requires only those packages that your application needs`.

### Understanding .NET Standard

| Version       | Usage         |
|:-------------:|:-------------:|
| .NET Core     | For cross-platform and new apps |
| .NET Framework| For legacy apps |
| Xamarin       | For mobile apps |

Each had strengths and weaknesses because they were all designed for different scenarios. This led to the problem that a developer had to learn three platforms, each with annoying quirks and limitations.
Because of that, Microsoft defined .NET Standard: a specification for a set of APIs that all .NET platforms could implement to indicate what level of compatibility they have. 
For example, basic support is indicated by a platform being compliant with .NET Standard 1.4

To use .NET Standard, you must install a .NET platform that implements the .NET Standard specification. .NET Standard 2.0 is implemented by the latest versions of .NET Framework, .NET Core, and Xamarin

Once .NET 6 is released in November 2021, the need for .NET Standard will significantly reduce, because there will be a single .NET for all platforms, including mobile. Even then, apps and websites created for .NET Framework will need to be supported so understanding that you can create .NET Standard 2.0 class libraries that are backward compatible with legacy .NET platforms is important to know

