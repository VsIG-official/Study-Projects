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

### Understanding intermediate language or CLR

The C# compiler (named Roslyn) used by the dotnet CLI tool converts your C# source code into `intermediate language (IL)` code and stores the IL in an assembly (a DLL or EXE file).
IL code statements are like assembly language instructions, which are executed by .NET's virtual machine, known as CoreCLR.

At runtime, CoreCLR loads the IL code from the assembly, the `just-in-time (JIT) compiler` compiles it into `native CPU instructions`, and then it is executed by the CPU on your machine.
The benefit of this three-step compilation process is that Microsoft is able to create CLRs for Linux and macOS, as well as for Windows. **The same IL code runs everywhere because of the second compilation process, which generates code for the native operating system and CPU instruction set**.

Regardless of which language the source code is written in, for example, C#, Visual Basic, or F#, `all .NET applications use IL code for their instructions stored in an assembly`.
Microsoft and others provide disassembler tools that can open an assembly and reveal this IL code, such as the ILSpy .NET Decompiler extension.

- CLR Steps
  - Convert Your code into IL (Intermediate Language)/MSI (Microsoft Intermediate Language)/CIL (Common Intermediate Language)
  - Store IL in assembly (DLL or EXE)
  - At runtime CLR loads IL and JIT compiler compiles it into native CPU instructions (depending on Your machine)
  - CPU executes this commands

### Comparing .NET technologies

| Technology    | Description   | Host OSes |
|:-------------:|:-------------:|:-:|
| .NET 5        | Modern feature set, full C# 9 support, port existing and create new Windows and Web apps and services | Windows, macOS, Linux |
| .NET Framework| Legacy feature set, limited C# 8 support, no C# 9 support, maintain existing applications | Windows only |
| Xamarin       | Mobile and desktop apps only | Android, iOS, macOS |

## C#
### Types
It's important to know that C# cannot exist alone; after all, it's a language that runs on variants of .NET. In theory, someone could write a compiler for C# that uses a different platform, with different underlying types.
In practice, the platform for C# is .NET, which provides tens of thousands of types to C#, including System.Int32, which is the C# keyword alias int maps to, as well as many more complex types, such as System.Xml.Linq.XDocument.

It's worth taking note that the term type is often confused with class. Have you ever played the parlor game Twenty Questions, also known as Animal, Vegetable, or Mineral? In the game, everything can be categorized as an animal, vegetable, or mineral.
In C#, every type can be categorized as a class, struct, enum, interface, or delegate. The C# keyword string is a class, but int is a struct. So, it is best to use the term type to refer to both

### Naming
#### Pascal case
- Use pascal casing ("PascalCasing") when naming a `class`, `record`, or `struct`.
- When naming an `interface`, use pascal casing in addition to prefixing the name with an `I`. This clearly indicates to consumers that it's an interface.
- When naming `public` members of types, such as `fields`, `properties`, `events`, `methods`, and `local functions`
- When writing positional records, use pascal casing for parameters as they're the public properties of the record

#### Camel case
- Use `camel casing` ("camelCasing") when naming `private` or `internal` fields, and prefix them with `_`
- When writing method parameters

- When working with `static` fields that are `private` or `internal`, use the `s_` prefix and for thread static use `t_`

#### Layout
- Use the default Code Editor settings (smart indenting, four-character indents, tabs saved as spaces)
- Write only one statement per line
- Write only one declaration per line
- If continuation lines are not indented automatically, indent them one tab stop (four spaces)
- Add at least one blank line between method definitions and property definitions
- Use parentheses to make clauses in an expression apparent, as shown in the following code:

```csharp
if ((val1 > val2) && (val1 > val3))
{
    // Take appropriate action.
}
```

#### Commenting
- Place the comment on a separate line, not at the end of a line of code
- Begin comment text with an uppercase letter
- End comment text with a period (.)
- Insert one space between the comment delimiter (//) and the comment text, as shown in the following example:
```csharp
// The following declaration creates a query. It does not run
// the query.
```
- Don't create formatted blocks of asterisks around comments:
```csharp
//***************************
//* Fancy important comment *
//***************************
```

### Language guidelines
> The following sections describe practices that the C# team follows to prepare code examples and samples

#### String data type
- Use string interpolation to concatenate short strings, as shown in the following code:
```csharp
string displayName = $"{nameList[n].LastName}, {nameList[n].FirstName}";
```
- To append strings in loops, especially when you're working with large amounts of text, use a StringBuilder object:
```csharp
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
```

#### Implicitly typed local variables
- Use implicit typing for local variables when the type of the variable is obvious from the right side of the assignment, or when the precise type is not important:
```csharp
var var1 = "This is clearly a string.";
var var2 = 27;
```
- Don't use var when the type is not apparent from the right side of the assignment. Don't assume the type is clear from a method name. A variable type is considered clear if it's a new operator or an explicit cast:
```csharp
int var3 = Convert.ToInt32(Console.ReadLine()); 
int var4 = ExampleClass.ResultSoFar();
```
- Don't rely on the variable name to specify the type of the variable. It might not be correct. In the following example, the variable name `inputInt` is misleading. It's a `string`:
```csharp
var inputInt = Console.ReadLine();
Console.WriteLine(inputInt);
```
- Avoid the use of `var` in place of `dynamic`. Use dynamic when you want run-time type inference
- `Use` implicit typing to determine the type of the loop variable in for loops. The following example uses implicit typing in a for statement:
```csharp
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
```
- `Don't` use implicit typing to determine the type of the loop variable in foreach loops. The following example uses explicit typing in a foreach statement:
```csharp
foreach (char ch in laugh)
{
    if (ch == 'h')
        Console.Write("H");
    else
        Console.Write(ch);
}
Console.WriteLine();
```

### Unsigned data types
- In general, use `int` rather than unsigned types. The use of int is common throughout C#, and it is easier to interact with other libraries when you use int.

### Arrays
- Use the `concise` syntax when you initialize arrays on the declaration line. In the following example, note that you can't use `var` instead of `string[]`.
```csharp
string[] vowels1 = { "a", "e", "i", "o", "u" };
```
- If you use `explicit` instantiation, you can use var
```csharp
var vowels2 = new string[] { "a", "e", "i", "o", "u" };
```
- If you specify an array size, you have to initialize the elements one at a time
```csharp
var vowels3 = new string[5];
vowels3[0] = "a";
vowels3[1] = "e";
// And so on.
```

## [Coding Style](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)
1. We use [Allman style](http://en.wikipedia.org/wiki/Indent_style#Allman_style) braces, where each brace begins on a new line. A single line statement block can go without braces but the block must be properly indented on its own line and must not be nested in other statement blocks that use braces (See rule 18 for more details). One exception is that a `using` statement is permitted to be nested within another `using` statement by starting on the following line at the same indentation level, even if the nested `using` contains a controlled block.
2. We use four spaces of indentation (no tabs).
3. We use `_camelCase` for internal and private fields and use `readonly` where possible. Prefix internal and private instance fields with `_`, static fields with `s_` and thread static fields with `t_`. When used on static fields, `readonly` should come after `static` (e.g. `static readonly` not `readonly static`).  Public fields should be used sparingly and should use PascalCasing with no prefix when used.
4. We avoid `this.` unless absolutely necessary.
5. We always specify the visibility, even if it's the default (e.g.
   `private string _foo` not `string _foo`). Visibility should be the first modifier (e.g.
   `public abstract` not `abstract public`).
6. Namespace imports should be specified at the top of the file, *outside* of
   `namespace` declarations, and should be sorted alphabetically, with the exception of `System.*` namespaces, which are to be placed on top of all others.
7. Avoid more than one empty line at any time. For example, do not have two
   blank lines between members of a type.
8. Avoid spurious free spaces.
   For example avoid `if (someVar == 0)...`, where the dots mark the spurious free spaces.
   Consider enabling "View White Space (Ctrl+R, Ctrl+W)" or "Edit -> Advanced -> View White Space" if using Visual Studio to aid detection.
9. If a file happens to differ in style from these guidelines (e.g. private members are named `m_member`
   rather than `_member`), the existing style in that file takes precedence.
10. We only use `var` when the type is explicitly named on the right-hand side, typically due to either `new` or an explicit cast, e.g. `var stream = new FileStream(...)` not `var stream = OpenStandardInput()`.
11. We use language keywords instead of BCL types (e.g. `int, string, float` instead of `Int32, String, Single`, etc) for both type references as well as method calls (e.g. `int.Parse` instead of `Int32.Parse`). See issue [#13976](https://github.com/dotnet/runtime/issues/13976) for examples.
12. We use PascalCasing to name all our constant local variables and fields. The only exception is for interop code where the constant value should exactly match the name and value of the code you are calling via interop.
13. We use PascalCasing for all method names, including local functions.
14. We use ```nameof(...)``` instead of ```"..."``` whenever possible and relevant.
15. Fields should be specified at the top within type declarations.
16. When including non-ASCII characters in the source code use Unicode escape sequences (\uXXXX) instead of literal characters. Literal non-ASCII characters occasionally get garbled by a tool or editor.
17. When using labels (for goto), indent the label one less than the current indentation.
18. When using a single-statement if, we follow these conventions:
    - Never use single-line form (for example: `if (source == null) throw new ArgumentNullException("source");`)
    - Using braces is always accepted, and required if any block of an `if`/`else if`/.../`else` compound statement uses braces or if a single statement body spans multiple lines.
    - Braces may be omitted only if the body of *every* block associated with an `if`/`else if`/.../`else` compound statement is placed on a single line.
19. Make all internal and private types static or sealed unless derivation from them is required.  As with any implementation detail, they can be changed if/when derivation is required in the future.

An [EditorConfig](https://editorconfig.org "EditorConfig homepage") file (`.editorconfig`) has been provided at the root of this repository, enabling C# auto-formatting conforming to the above guidelines. (and was reworked a little, 'cause not every item was there)

(as for Me, it's outdated) We also use the [.NET Codeformatter Tool](https://github.com/dotnet/codeformatter) to ensure the code base maintains a consistent style over time, the tool automatically fixes the code base to conform to the guidelines outlined above.

### Example File:

``ObservableLinkedList`1.cs:``

```C#
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Win32;

namespace System.Collections.Generic
{
    public partial class ObservableLinkedList<T> : INotifyCollectionChanged, INotifyPropertyChanged
    {
        private ObservableLinkedListNode<T> _head;
        private int _count;

        public ObservableLinkedList(IEnumerable<T> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            foreach (T item in items)
            {
                AddLast(item);
            }
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public int Count
        {
            get { return _count; }
        }

        public ObservableLinkedListNode AddLast(T value)
        {
            var newNode = new LinkedListNode<T>(this, value);

            InsertNodeBefore(_head, node);
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler handler = CollectionChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void InsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            ...
        }

        ...
    }
}
```

``ObservableLinkedList`1.ObservableLinkedListNode.cs:``

```C#
using System;

namespace System.Collections.Generics
{
    partial class ObservableLinkedList<T>
    {
        public class ObservableLinkedListNode
        {
            private readonly ObservableLinkedList<T> _parent;
            private readonly T _value;

            internal ObservableLinkedListNode(ObservableLinkedList<T> parent, T value)
            {
                Debug.Assert(parent != null);

                _parent = parent;
                _value = value;
            }

            public T Value
            {
                get { return _value; }
            }
        }

        ...
    }
}
```

## Sources
- C# 9 and .NET 5 - Modern Cross-Platform Development | [GitHub](https://github.com/markjprice/cs9dotnet5)
- C# Coding Conventions | [Site](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- C# Coding Style | [GitHub](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)
