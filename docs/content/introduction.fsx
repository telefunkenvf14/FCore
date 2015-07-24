(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin/FCore"

(**
Introducing your project
========================

Say more

*)
#r "FCore.dll"
open FCore
open FCore.Random

let rng = new MT19937Rng()
let matrix = rand rng 3 4

(**
Some more info
*)
