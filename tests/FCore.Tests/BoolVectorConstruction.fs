module FCore.Tests

open FCore
open NUnit.Framework
open FsUnit

[<Test>]
let ``Constructs BoolVector from int64 and bool value`` () =
  use v = new BoolVector(5L, false)
  v.LongLength |> should equal 5L
  v.ToArray() |> should equal [|false;false;false;false;false|]
