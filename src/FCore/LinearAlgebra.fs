namespace FCore
open System
open Overloading

module LinearAlgebra =

    let inline chol (x :'S) : 'S = ((^T or ^S) : (static member Chol: ^T * ^S -> ^S) DummyType, x)

    let inline cholInv (x :'S) : 'S = ((^T or ^S) : (static member CholInv: ^T * ^S -> ^S) DummyType, x)

    let inline cholSolve (a :'S) (b : 'S) : 'S = ((^T or ^S) : (static member CholSolve: ^T * ^S * ^S -> ^S) DummyType, a, b)

    let inline lu (x :'S) : 'S * 'S * int[] = ((^T or ^S) : (static member Lu: ^T * ^S -> 'S * 'S * int[]) DummyType, x)

    let inline luInv (x :'S) : 'S = ((^T or ^S) : (static member LuInv: ^T * ^S -> ^S) DummyType, x)

    let inline luSolve (a :'S) (b : 'S) : 'S = ((^T or ^S) : (static member LuSolve: ^T * ^S * ^S -> ^S) DummyType, a, b)

    let inline qr (x :'S) : 'S * 'S = ((^T or ^S) : (static member Qr: ^T * ^S -> ^S * ^S) DummyType, x)

    let inline qrSolveFull (a :'S) (b : 'S) : 'S = ((^T or ^S) : (static member QrSolveFull: ^T * ^S * ^S -> ^S) DummyType, a, b)

    let inline qrSolve (a :'S) (b : 'S) (tol : 'U) : 'S * int = ((^T or ^S) : (static member QrSolve: ^T * ^S * ^S * ^U -> ^S * int) DummyType, a, b, tol)

    let inline svdSolve (a :'S) (b : 'S) (tol : 'U) : 'S * int = ((^T or ^S) : (static member SvdSolve: ^T * ^S * ^S * ^U -> ^S * int) DummyType, a, b, tol)

    let inline svdValues (x :'S) : 'U = ((^T or ^S) : (static member SvdValues: ^T * ^S -> ^U) DummyType, x)

    let inline svd (x :'S) : 'S * 'U * 'S = ((^T or ^S) : (static member Svd: ^T * ^S -> ^S * ^U * ^S) DummyType, x)

    let inline eig (x :'S) : 'S * 'U = ((^T or ^S) : (static member Eig: ^T * ^S -> ^S * ^U) DummyType, x)

    let inline eigValues (x :'S) : 'U = ((^T or ^S) : (static member EigValues: ^T * ^S -> ^U) DummyType, x)





