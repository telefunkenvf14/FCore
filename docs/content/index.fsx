(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin/FCore"


(**
FCore Numerical Library
======================

FCore is a high performance F# numerical library.

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The FCore library can be <a href="https://nuget.org/packages/FCore">installed from NuGet</a>:
      <pre>PM> Install-Package FCore</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Example
-------

This code example demonstrates using various functions defined in this library.

*)

#r "FCore.dll"
open FCore
open FCore.Math
open FCore.Random
open FCore.LinearAlgebra
open FCore.BasicStats

let rng = new MT19937Rng()
let vector1 : Vector = rand rng 5
let matrix1 = rand rng 5 5
let vector2 = exp(vector1) + 2.0
let matrix2 = exp(matrix1) + 2.0
let l, u, p = lu matrix1
let variance1 = var vector1
let variance2 = var matrix1 ColumnAxis


(** And the variable `matrix1` has the following value: *)
(*** include-value: matrix1 ***)

(**

Documentation
-----------------------

The library comes with a comprehensive library guide: 

 * [Introduction](introduction.html) contains an overview of the library.
 * [BoolVector](BoolVector.html) introduces BoolVector type and related functions
 * [Vector](Vector.html) introduces Vector type and related functions
 * [BoolMatrix](BoolMatrix.html) introduces BoolMatrix type and related functions
 * [Matrix](Matrix.html) introduces Matrix type and related functions
 * [Linear Algebra](LinearAlgebra.html) introduces matrix factorizations and linear solvers
 * [Vector and Matrix Functions](VectorAndMatrixFunctions.html) introduces vector and matrix functions
 * [Random Number Generators](RandomNumberGenerators.html) introduces random number generators
 * [Basic Stats](BasicStats.html) introduces basic statistical functions
 * [Vector and Matrix Expressions](VectorAndMatrixExpressions.html) introduces vector and matrix expressions

   
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation.

The library source code is available under MIT/X11 license. For more information see the 
[License file][license] in the GitHub repository.

The library uses Intel Math Kernel Library for high performance. This software is not open source and therefore FCore distribution on Nuget has its own license. 

  [content]: https://github.com/Statfactory/FCore/tree/master/docs/content
  [gh]: https://github.com/Statfactory/FCore
  [issues]: https://github.com/Statfactory/FCore/issues
  [readme]: https://github.com/Statfactory/FCore/blob/master/README.md
  [license]: https://github.com/Statfactory/FCore/blob/master/LICENSE.txt
*)
