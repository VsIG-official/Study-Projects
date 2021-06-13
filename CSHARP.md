## Understanding .NET
### Understanding .NET Framework

.NET Framework is a development platform that includes a `Common Language Runtime (CLR)`, which manages the execution of code, and a `Base Class Library (BCL)`, which provides a rich library of classes to build applications from.
Microsoft originally designed .NET Framework to have the possibility of being cross-platform, but Microsoft put their implementation effort into making it work best with Windows

All of the apps on a computer written for .NET Framework share the same version of the CLR and libraries stored in the `Global Assembly Cache (GAC)`, which can lead to issues if some of them need a specific version for compatibility

`Good Practice`: Practically speaking, .NET Framework is Windows-only and a legacy platform. Do not create new apps using it

### Understanding the Mono and Xamarin projects

