## Understanding .NET
### Understanding .NET Framework

.NET Framework is a development platform that includes a `Common Language Runtime (CLR)`, which manages the execution of code, and a `Base Class Library (BCL)`, which provides a rich library of classes to build applications from.
Microsoft originally designed .NET Framework to have the possibility of being cross-platform, but Microsoft put their implementation effort into making it work best with Windows

All of the apps on a computer written for .NET Framework share the same version of the CLR and libraries stored in the `Global Assembly Cache (GAC)`, which can lead to issues if some of them need a specific version for compatibility

`Good Practice`: Practically speaking, .NET Framework is Windows-only and a legacy platform. Do not create new apps using it

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

