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
- Use meaningful names without special characters

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

## Variables
### Strings
#### Literal values
- Literal string: Characters enclosed in double-quote characters. They can use escape characters like \t for tab.

- When you assign to a variable, you often, but not always, assign a `literal` value. But what is a literal value? A `literal is a notation that represents a fixed value`. Data types have different notations for their literal values: True, false, 10, 'T', '\n' and etc.

#### Verbatim strings
- Verbatim string: A literal string prefixed with @ to disable escape characters so that a backslash is a backslash.

- When storing text in a string variable, you can include escape sequences, which represent special characters like tabs and new lines using a backslash, as shown in the following code:
```csharp
string fullNameWithTabSeparator = "Bob\tSmith";
```
- But what if you are storing the path to a file, and one of the folder names starts with a T, as shown in the following code:
```csharp
string filePath = "C:\televisions\sony\bravia.txt";
```

- The compiler will convert the \t into a tab character and you will get errors!
You must prefix with the @ symbol (verbatim = literally) to use a verbatim literal string, as shown in the following code:
```csharp
string filePath = @"C:\televisions\sony\bravia.txt";
```

#### Interpolated String
- Interpolated string: A literal string prefixed with $ to enable embedded formattedvariables. You will learn more about this later in this chapter.

### Numbers
Numbers can be `natural` numbers, such as `42`, used for counting (also called `whole` numbers); they can also be `negative` numbers, such as `-42` (called `integers`); or, they can be `real` numbers, such as `3.9` (with a `fractional part`), which are called `single-` or `double-precision floating point` numbers in computing

```csharp
// unsigned integer means positive whole number
// including 0
uint naturalNumber = 23;
// integer means negative or positive whole number
// including 0
int integerNumber = -23;
// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;
// double means double-precision floating point
double anotherRealNumber = 2.3; // double literal
```

#### Whole numbers (42)
- The decimal number system, also known as Base 10, has 10 as its base, meaning there are ten digits, from 0 to 9. Although it is the number base most commonly used by human civilizations, other number-base systems are popular in science, engineering, and computing. The binary number system also known as Base 2 has two as its base, meaning there are two digits, 0 and 1.

- The following table shows how computers store the decimal number 10. Take note of the bits with the value 1 in the 8 and the 2 columns; 8 + 2 = 10:

| 128 | 64 | 32 | 16 | 8 | 4 | 2 | 1 |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 | 0 | 0 | 0 | 1 | 0 | 1 | 0 |

- So, 10 in decimal is 00001010 in binary.

- Two of the improvements seen in C# 7.0 and later are the use of the underscore character, `_`, as a digit separator, and support for binary literals. You can insert underscores anywhere into the digits of a number literal, including decimal, binary, or hexadecimal notation, to improve legibility. For example, you could write the value for 1 million in decimal notation, that is, Base 10, as `1_000_000`

- To use `binary notation`, that is, Base 2, using only 1s and 0s, start the number literal with `0b`. To use `hexadecimal notation`, that is, Base 16, using 0 to 9 and A to F, start the number literal with `0x`.

```csharp
// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
```

#### Real Numbers (3.9)
- Computers cannot always exactly represent floating point numbers. The float and double types store real numbers using single- and double-precision floating points.

- Most programming languages implement the IEEE Standard for Floating-Point Arithmetic. IEEE 754 ([1](https://github.com/VsIG-official/Study-Projects/blob/master/Docs/IEEE754-97.PDF),[2](https://github.com/VsIG-official/Study-Projects/blob/master/Docs/ieee754.pdf),[3](https://github.com/VsIG-official/Study-Projects/blob/master/Docs/%D0%A1%D1%82%D0%B0%D0%BD%D0%B4%D0%B0%D1%80%D1%82%20IEEE%20754.doc)) (more information [there](https://ciechanow.ski/exposing-floating-point/)) is a technical standard for floating-point arithmetic established in 1985 by the Institute of Electrical and Electronics Engineers (IEEE)

- The following table shows a simplification of how a computer represents the number 12.75 in binary notation. Note the bits with the value 1 in the 8, 4, ½, and ¼ columns.
8 + 4 + ½ + ¼ = 12¾ = 12.75

| 128 | 64 | 32 | 16 | 8 | 4 | 2 | 1 | . | ½ | ¼ | 1/8 | 1/16 |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 | 0 | 0 | 0 | 1 | 1 | 0 | 0 | . | 1 | 1 | 0 | 0 |

- So, 12.75 in decimal is 00001100.1100 in binary. As you can see, the number 12.75 can be exactly represented using bits. However, some numbers can't.

#### Comparing some types
- An int variable uses four bytes of memory and can store positive or negative numbers up to about 2 billion. A double variable uses eight bytes of memory and can store much bigger values! A decimal variable uses 16 bytes of memory and can store big numbers, but not as big as a double type.

> But you may be asking yourself, why might a double variable be able to store bigger numbers than a decimal variable, yet it's only using half the space in memory? Well, let's now find out!

- If You will write this code:
```csharp
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
 Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
 Console.WriteLine($"{a} + {b} does NOT equal 0.3");
}
```

- then output will be like this:
```csharp
Using doubles:
0.1 + 0.2 does NOT equal 0.3
```

>

- The double type is not guaranteed to be accurate because some [numbers literally cannot be represented as floating-point values](https://www.exploringbinary.com/why-0-point-1-does-not-exist-in-floating-point/) or [this](https://floating-point-gui.de/basic/)

- As a rule of thumb, you should only use double when accuracy, especially when comparing the equality of two numbers, is not important. An example of this may be when you're measuring a person's height.
- The problem with the preceding code is illustrated by how the computer stores the number 0.1, or multiples of 0.1. To represent 0.1 in binary, the computer stores 1 in the 1/16 column, 1 in the 1/32 column, 1 in the 1/256 column, 1 in the 1/512 column, and so on.
- The number 0.1 in decimal is 0.00011001100110011… repeating forever:

| 4 | 2 | 1 | . | ½ | ¼ | 1/8 | 1/16 | 1/32 | 1/64 | 1/128 | 1/256 | 1/512 | 1/1024 | 1/2048 |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 0 | 0 | 0 | . | 0 | 0 | 0 | 1 | 1 | 0 | 0 | 1 | 1 | 0 | 0 |

- Binary floating point math is like this. In most programming languages, it is based on the `IEEE 754 standard`. The crux of the problem is that numbers are represented in this format as a whole number times a `power of two`; rational numbers (such as 0.1, which is 1/10) whose denominator `is not a power of two` cannot be exactly represented.

- 0.1 is one-tenth, or 1/10. To show it in binary — that is, as a bicimal — divide binary 1 by binary 1010, using binary long division:

- The division process would repeat forever — and so too the digits in the quotient — because 100 (“one-zero-zero”) reappears as the working portion of the dividend. Recognizing this, we can abort the division and write the answer in repeating bicimal notation, as 0.00011.
<p align="center">
  <img src="https://github.com/VsIG-official/Study-Projects/blob/master/Docs/OneTenthLongDivision.png" data-canonical-src="https://github.com/VsIG-official/Study-Projects/blob/master/Docs/OneTenthLongDivision.png"/>
</p>

- There is another example with doubles:

```csharp
      Console.WriteLine("Using doubles:");
      double a = 0.2;
      double b = 0.2;
      if (a + b == 0.4)
      {
          Console.WriteLine($"{a} + {b} equals 0.4");
      }
      else
      {
          Console.WriteLine($"{a} + {b} does NOT equal 0.4");
      }
```

- then output will be like this:
```csharp
Using doubles:
0.2 + 0.2 equals 0.4
```

- Why do other calculations like 0.1 + 0.4 work correctly?
In that case, the result (0.5) can be represented exactly as a floating-point number, and it’s possible for rounding errors in the input numbers to cancel each other out - But that can’t necessarily be relied upon (e.g. when those two numbers were stored in differently sized floating point representations first, the rounding errors might not offset each other).

In other cases like 0.1 + 0.3, the result actually isn’t really 0.4, but close enough that 0.4 is the shortest number that is closer to the result than to any other floating-point number. Many languages then display that number instead of converting the actual result back to the closest decimal fraction.

- Also to compare doubles right We can use instead of this code:

```csharp
public static void WrongMain()
{
    // в бинарном виде 0.1 представляется бесконечной дробью 0.00011001100...,
    // в типах данных float и double хранится только начало этой дроби,
    // поэтому число 0.1 представляется с погрешностью. 
    double x = 1.0 / 10; 
    double sum = 0;
    for (int i = 0; i < 10; i++)
        sum += x;
    Console.WriteLine(sum == 1);
}
```

- this:
```csharp
static void RightMain()
{
    double x = 1.0 / 10;
    double sum = 0;
    for (int i = 0; i < 10; i++)
        sum += x;
    Console.WriteLine(Math.Abs(sum - 1) < 1e-9);
}
```

- but, in the end, use decimal

- `Good Practice`: Never compare double values using ==. During the First Gulf War, an American Patriot missile battery used double values in its calculations. The inaccuracy caused it to fail to track and intercept an incoming Iraqi Scud missile, and 28 soldiers were killed; you can read about this at https://www.ima.umn.edu/~arnold/disasters/patriot.html

>

- But if We use this code:
```csharp
Console.WriteLine("Using decimals:");
decimal c = 0.1M; // M suffix means a decimal literal value
decimal d = 0.2M;
if (c + d == 0.3M)
{
 Console.WriteLine($"{c} + {d} equals 0.3");
}
else
{
 Console.WriteLine($"{c} + {d} does NOT equal 0.3");
}
```

- then output will be like this:
```csharp
Using decimals:
0.1 + 0.2 equals 0.3
```
- The `decimal` type is accurate because it stores the number as a `large integer and shifts the decimal point`. For example, `0.1` is stored as `1`, with a note to shift the decimal point one place to the left. `12.75` is stored as `1275`, with a note to shift the decimal point two places to the left.

- `Good Practice`: Use `int` for whole numbers and `double` for real numbers that will not be compared to other values. Use `decimal` for money, CAD drawings, general engineering, and wherever the accuracy of a real number is important

#### Some arithmetic operataions and their explanation
```csharp
int a = 1;
int b = 2;

int c = b / a;
double d = b / a;
```
- c and d will be the same, 'cause firstly We are doing `whole division` and then We cast this into int and double. But if We do like this:

```csharp
int a = 1;
int b = 2;

int c = b / a;
double d = (double)b / a; or double d = 1.0 / 2;
```
- then We will cast to double / understand, that We work with double, and will get proper result

#### Var
- Var is some sort of syntactic sugar
- Compilator will define type of the variable by itself - It doesn't mean, that type will be defined while the program is running or it's variable of general type and You could do everything You want
- The contextual keyword `var` may only appear within a local variable declaration: We can't write `var a;` even as a field

### =
- = as +, - and etc. returns some value. For example:
```csharp
var a = 2;
var b = 4;
var c = 6;

Console.WriteLine(b = c);

a = b = c;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
```

- and result will be the same - `6`

### ++ Rebus
```csharp
      Console.WriteLine(a++ + ++a);
```

Output will be 6: 2 + 4, but in the end a = 4

### Local variables vs Global variables (A.K.A. fields)
| Local | Global (should be static) (Fields) |
|:---:|:---:|
| Need to be initialzed by user | Can be initialized by Default |
| Exist inly in current method | Can be accessed from every part of code |
| Will be initialized after program starts | Will be initialized before program starts |

P.S. Use global variables only when they are needed (follow Best practises)

## Methods
- Static method - called from class (Console.Write)
- Dynamic method - called from variable (str.ToString)

### Type Casting
- Implicit Cast
```csharp
int myInt = 9;
double myDouble = myInt;
```
- Explicit Cast
```csharp
double myDouble = 9.78;
int myInt = (int) myDouble;
```
- Type Conversion
```csharp
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```

### Object and Dynamic
- There is a special type named `object` that can store any type of data, but its flexibility comes at the cost of messier code and possibly poor performance. Because of those two reasons, you should avoid it whenever possible

```csharp
object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");
```

- There is another special type named `dynamic` that can also store any type of data, but even more than object, its flexibility comes at the cost of performance. The dynamic keyword was introduced in C# 4.0. However, unlike object, the value stored in the variable can have its members invoked without an explicit cast

```csharp
// storing a string in a dynamic object
dynamic anotherName = "Ahmed";

// this compiles but would throw an exception at run-time
// if you later store a data type that does not have a
// property named Length
int length = anotherName.Length;
```

One limitation of dynamic is that Visual Studio Code cannot show IntelliSense to help you write the code. This is because the compiler cannot check what the type is during build time. Instead, the CLR checks for the member at runtime and throws an exception if it is missing

### Default values for types
- Most of the primitive types except `string` are `value types`, which means that they must have a value. You can determine the default value of a type using the `default()` operator.
- The `string` type is a `reference` type. This means that `string variables contain the memory address of a value, not the value itself`. A `reference type variable can have a null value`, which is a literal that indicates that the variable does not reference anything (yet). `null is the default for all reference types`.

```csharp
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine(
 $"default(DateTime) = {default(DateTime)}");
Console.WriteLine(
 $"default(string) = {default(string)}");
```

Output:
```csharp
default(int) = 0
default(bool) = False
default(DateTime) = 01/01/0001 00:00:00
default(string) = // null
```

### Nullable type
- By default, value types like int and DateTime must always have a value, hence their name. Sometimes, for example, when reading values stored in a database that allows empty, missing, or null values, it is convenient to allow a value type to be null. We call this a nullable value type
- You can enable this by adding a question mark as a suffix to the type when declaring a variable. Let's see an example:

```csharp
int thisCannotBeNull = 4;
thisCannotBeNull = null; // compile error!

int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
```

- Output:
```csharp
// this blank line is null value
0
7
7
```

### Nullable reference types
- The most significant change to the language in C# 8.0 was the introduction of nullable and nonnullable reference types. "But wait!", you are probably thinking, "Reference types are already nullable!"
- And you would be right, but in C# 8.0 and later, reference types can be configured to no longer allow the null value by setting a file- or project-level option to enable this useful new feature. Since this is a big change for C#, Microsoft decided to make the feature opt-in.

- During the transition, you can choose between several approaches for your own projects:
• Default: No changes are needed. Non-nullable reference types are not supported.
• Opt-in project, opt-out files: Enable the feature at the project level and, for any files that
need to remain compatible with old behavior, opt out. This is the approach Microsoft is
using internally while it updates its own packages to use this new feature.
• Opt-in files: Only enable the feature for individual files.

### Checking for Null
- Checking whether a nullable reference type or nullable value type variable currently contains null is important because if you do not, a NullReferenceException can be thrown, which results in an error. You should check for a null value before using a nullable variable, as shown in the following code:
```csharp
// check that the variable is not null before using it
if (thisCouldBeNull != null)
{
 // access a member of thisCouldBeNull
 int length = thisCouldBeNull.Length; // could throw exception
 ...
}
```

- If you are trying to use a `member of a variable` that might be null, use the null-conditional operator ?., as shown in the following code:
```csharp
string authorName = null;
// the following throws a NullReferenceException
int x = authorName.Length;
// instead of throwing an exception, null is assigned to y
int? y = authorName?.Length;
```

- Sometimes you want to either assign a variable to a result or use an alternative value, such as 3, if the variable is null. You do this using the null-coalescing operator, ??, as shown in the following code:
```csharp
// result will be 3 if authorName?.Length is null
var result = authorName?.Length ?? 3;
Console.WriteLine(result);
```

## Language guidelines
> The following sections describe practices that the C# team follows to prepare code examples and samples

### String data type
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

### Implicitly typed local variables
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

### Delegates
- Use [Func<> and Action<>](https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambdas) instead of defining delegate types. In a class, define the delegate method.
```csharp
public static Action<string> ActionExample1 = x => Console.WriteLine($"x is: {x}");

public static Action<string, string> ActionExample2 = (x, y) => 
    Console.WriteLine($"x is: {x}, y is {y}");

public static Func<string, int> FuncExample1 = x => Convert.ToInt32(x);

public static Func<int, int, int> FuncExample2 = (x, y) => x + y;
```
- Call the method using the signature defined by the `Func<>` or `Action<>` delegate.
```csharp
ActionExample1("string for x");

ActionExample2("string for x", "string for y");

Console.WriteLine($"The value is {FuncExample1("1")}");

Console.WriteLine($"The sum is {FuncExample2(1, 2)}");
```
- If you create instances of a delegate type, use the concise syntax. In a class, define the delegate type and a method that has a matching signature.
```csharp
public delegate void Del(string message);

public static void DelMethod(string str)
{
    Console.WriteLine("DelMethod argument: {0}", str);
}
```
- Create an instance of the delegate type and call it. The following declaration shows the condensed syntax.
```csharp
Del exampleDel2 = DelMethod;
exampleDel2("Hey");
```
- The following declaration uses the full syntax.
```csharp
Del exampleDel1 = new Del(DelMethod);
exampleDel1("Hey");
```

### try-catch and using statements in exception handling
- Use a try-catch statement for most exception handling.
```csharp
static string GetValueFromArray(string[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (System.IndexOutOfRangeException ex)
    {
        Console.WriteLine("Index is out of range: {0}", index);
        throw;
    }
}
```
- Simplify your code by using the C# using statement. If you have a try-finally statement in which the only code in the `finally` block is a call to the Dispose method, use a `using` statement instead.
In the following example, the `try-finally` statement only calls `Dispose` in the `finally` block.
```csharp
Font font1 = new Font("Arial", 10.0f);
try
{
    byte charset = font1.GdiCharSet;
}
finally
{
    if (font1 != null)
    {
        ((IDisposable)font1).Dispose();
    }
}
```
You can do the same thing with a using statement.
```csharp
using (Font font2 = new Font("Arial", 10.0f))
{
    byte charset2 = font2.GdiCharSet;
}
```
In C# 8 and later versions, use the new [using syntax](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement) that doesn't require braces:
```csharp
using Font font3 = new Font("Arial", 10.0f);
byte charset3 = font3.GdiCharSet;
```

### `&&` and `||` operators
- To avoid exceptions and increase performance by skipping unnecessary comparisons, use `&&` instead of `&` and `||` instead of `|` when you perform comparisons, as shown in the following example.
```csharp
Console.Write("Enter a dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());

if ((divisor != 0) && (dividend / divisor > 0))
{
    Console.WriteLine("Quotient: {0}", dividend / divisor);
}
else
{
    Console.WriteLine("Attempted division by 0 ends up here.");
}
```

If the divisor is 0, the second clause in the if statement would cause a run-time error. But the && operator short-circuits when the first expression is false. That is, it doesn't evaluate the second expression. The & operator would evaluate both, resulting in a run-time error when `divisor` is 0

- `|` and `&` are `logical or` and `logical and`, when `||` and `&&` are `conditional logical or` and `conditional logical and`

### `new` operator
- Use one of the concise forms of object instantiation, as shown in the following declarations. The second example shows syntax that is available starting in C# 9.
```csharp
var instance1 = new ExampleClass();
```
```csharp
ExampleClass instance2 = new();
```
The preceding declarations are equivalent to the following declaration.
```csharp
ExampleClass instance2 = new ExampleClass();
```
- Use object initializers to simplify object creation, as shown in the following example
```csharp
var instance3 = new ExampleClass { Name = "Desktop", ID = 37414,
    Location = "Redmond", Age = 2.3 };
```
The following example sets the same properties as the preceding example but doesn't use initializers.
```csharp
var instance4 = new ExampleClass();
instance4.Name = "Desktop";
instance4.ID = 37414;
instance4.Location = "Redmond";
instance4.Age = 2.3;
```

### Event handling
- If you're defining an event handler that you don't need to remove later, use a lambda expression.
```csharp
public Form2()
{
    this.Click += (s, e) =>
        {
            MessageBox.Show(
                ((MouseEventArgs)e).Location.ToString());
        };
}
```
The lambda expression shortens the following traditional definition.
```csharp
public Form1()
{
    this.Click += new EventHandler(Form1_Click);
}

void Form1_Click(object sender, EventArgs e)
{
    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
}
```

### Static members
- Call [static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static) members by using the class name: ClassName.StaticMember. This practice makes code more readable by making static access clear. Don't qualify a static member defined in a base class with the name of a derived class. While that code compiles, the code readability is misleading, and the code may break in the future if you add a static member with the same name to the derived class.

### LINQ queries
- Use meaningful names for query variables. The following example uses seattleCustomers for customers who are located in Seattle.
```csharp
var seattleCustomers = from customer in customers
                       where customer.City == "Seattle"
                       select customer.Name;
```
- Use aliases to make sure that property names of anonymous types are correctly capitalized, using Pascal casing.
```csharp
var localDistributors =
    from customer in customers
    join distributor in distributors on customer.City equals distributor.City
    select new { Customer = customer, Distributor = distributor };
```
- Rename properties when the property names in the result would be ambiguous. For example, if your query returns a customer name and a distributor ID, instead of leaving them as Name and ID in the result, rename them to clarify that Name is the name of a customer, and ID is the ID of a distributor.
```csharp
var localDistributors2 =
    from customer in customers
    join distributor in distributors on customer.City equals distributor.City
    select new { CustomerName = customer.Name, DistributorID = distributor.ID };
```
- Use implicit typing in the declaration of query variables and range variables.
```csharp
var seattleCustomers = from customer in customers
                       where customer.City == "Seattle"
                       select customer.Name;
```
- Align query clauses under the [from](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/from-clause) clause, as shown in the previous examples.
- Use [where](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-clause) clauses before other query clauses to ensure that later query clauses operate on the reduced, filtered set of data.
```csharp
var seattleCustomers2 = from customer in customers
                        where customer.City == "Seattle"
                        orderby customer.Name
                        select customer;
```
- Use multiple from clauses instead of a [join](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause) clause to access inner collections. For example, a collection of Student objects might each contain a collection of test scores. When the following query is executed, it returns each score that is over 90, along with the last name of the student who received the score.
```csharp
var scoreQuery = from student in students
                 from score in student.Scores
                 where score > 90
                 select new { Last = student.LastName, score };
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

### Stack vs Heap
![Pict](https://github.com/VsIG-official/Study-Projects/blob/master/Docs/pict.png)

![Pict2](https://github.com/VsIG-official/Study-Projects/blob/master/Docs/pict2.png)

## [Best Practises](https://www.youtube.com/watch?v=-9b8NRqjUFM&t=474s&ab_channel=IAmTimCorey)
- One class per file
- Use properties - not public variables
- One method do one job
- Keep it simple (don't use "hard" things instead of "easy" ones)
- Be consistent (if You write `var` in foreach loop, then do it everytime)
- Use $ to concate strings instead of ""Hi " + smth "
- Avoid global variables
[And This](https://docs.google.com/document/d/1GZX3_0Cq3RI2GmhvisUsB5l1QR6MDPIMqAlONgnG_2c/edit#)
- Use the `plural` when naming collections:

Not Right:
```csharp
Apple[] Apple
```

Right:
```csharp
Apple[] Apples
```

- Do not write the type of collection in the name. Exception if there is a collection of another type with the same data

Not Right:
```csharp
Orange[] ArrayOfOranges
List<Apple> AppleList
```

Right:
```csharp
Orange[] Oranges
List<Apple> Apples
```

- Do not use `of`, `the` and a `in` names:

Not Right:
```csharp
ColorOfCar
theSun
aStar
```

Right:
```csharp
CarColor
sun
star
```

- Name Boolean variables as questions that can be answered by yes or no. Do not use the name flag:

Not Right:
```csharp
var flag = false;
```

Right:
```csharp
var isSorted = false;
```

- Don't leave blank lines after the method declaration and after return:

Not Right:
```csharp
int GetOne()
{

   return 1;

}
```

Right:
```csharp
int GetOne()
{
    return 1;
}
```

- Don't write else if you leave the if body everywhere above

Not Right:
```csharp
if (a > b)
{
   return 10;
}
else 
{
   … 
   return 20;
}
```

Right:
```csharp
if (a > b)
{
   return 10;
}

… 
return 20;
```

- Do not compare a bool to a constant with ==

Not Right:
```csharp
if (success == true)

…

if (success == false)
```

Right:
```csharp
if (success)

…

if (!success)
```

- The names of the methods must begin with a verb

Not Right:
```csharp
public static double Length()
```

Right:
```csharp
public static double GetLength()
```

- Observe the order of elements within the class. First fields and properties, then constructor, then public methods, then private methods.

- Leave a blank line between the methods

Not Right:
```csharp
public static void DoSomething()
{
    ...
}
public static void DoSomethingElse()
{
    ...
}
```

Right:
```csharp
public static void DoSomething()
{
    ...
}

public static void DoSomethingElse()
{
    ...
}
```

- Put a space after for, if, ...

Not Right:
```csharp
if(a > b)
    return 0;
```

Right:
```csharp
if (a > b)
    return 0;
```

- Frame arithmetic, logical, and assignment operators with spaces

Not Right:
```csharp
if (a>b) 
    c=0; 
```

Right:
```csharp
if (a > b) 
    c = 0; 
```

- Move the expressions so that the new line starts with the operator

Not Right:
```csharp
if (longExpression &&
    anotherExpression)
```

Right:
```csharp
if (longExpression
   && anotherExpression)
```

- To write single-line properties, use =>

Not Right:
```csharp
public int Length
{
    get {return bytes.Length;}
}
```

Right:
```csharp
public int Length => bytes.Length;
```

- When writing a long chain of method calls, write each call on a new line

Not Right:
```csharp
return lines.Where(...)
    .Select(...)...
```

Right:
```csharp
return lines
    .Where(...)
    .Select(...)
    ...
```

- in `for` loop start Your `i` from 0 and end with `<`, not `i=1` and `<=`

## Design Patterns
- [Don't Repeat Yourself](https://www.youtube.com/watch?v=dhnsegiPXoo&ab_channel=IAmTimCorey)
> You can use Your code as .NET dll
 

## Small Visual Studio Tips
[1](https://www.youtube.com/watch?v=qv6ZflueASY&ab_channel=IAmTimCorey)
- Use editor config
- Use Code cleanup (and set it up)
- Use intellicode
- Use refactoring

## Sources
- C# 9 and .NET 5 - Modern Cross-Platform Development | [GitHub](https://github.com/markjprice/cs9dotnet5)
- C# Coding Conventions | [Site](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- C# Coding Style | [GitHub](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)
