namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FCore")>]
[<assembly: AssemblyProductAttribute("FCore")>]
[<assembly: AssemblyDescriptionAttribute("F# numerical library")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
