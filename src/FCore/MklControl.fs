namespace Fmat.Numerics
#nowarn "9"

open System
open System.Text
open System.Runtime.InteropServices
open Microsoft.FSharp.NativeInterop
open System.Collections.Generic

type MklControl =
    static member SetMaxThreads(n : int) =
        MklFunctions.Set_Max_Threads(n)


