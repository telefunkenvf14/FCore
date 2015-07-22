// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.Git
open Fake.AssemblyInfoFile
open Fake.ReleaseNotesHelper
open System
open System.IO
open System.IO.Compression

let fcoreBuildDir =  __SOURCE_DIRECTORY__ @@ "bin\FCore"
let fcoreMklBuildDir =  __SOURCE_DIRECTORY__ @@ "bin\FCore.MKL"
let fcoreMklx86Dll = fcoreMklBuildDir @@ "\FCore.MKL.x86.dll"
let fcoreMklx64Dll = fcoreMklBuildDir @@ "\FCore.MKL.x64.dll"
let fcoreMklx86Zip = fcoreMklBuildDir @@ "\FCore.MKL.x86.zip"
let fcoreMklx64Zip = fcoreMklBuildDir @@ "\FCore.MKL.x64.zip"
let fcoreProj = __SOURCE_DIRECTORY__ @@ "src\FCore\FCore.fsproj"
let fcoreTestsProj = __SOURCE_DIRECTORY__ @@ "tests\FCore.Tests\FCore.Tests.fsproj"
let testAssemblies = __SOURCE_DIRECTORY__ @@ "tests/**/bin/Release/*Tests*.dll"
let nunitPath = __SOURCE_DIRECTORY__ @@ "packages/NUnit.Runners/tools"

let compressFile (path : string) =
    let data = File.ReadAllBytes path
    use memoryStream = new MemoryStream()
    use deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress)
    deflateStream.Write(data, 0, data.Length)
    deflateStream.Flush()
    deflateStream.Close()
    let res = memoryStream.ToArray()
    File.WriteAllBytes(path.Replace("dll", "zip"), res)


Target "Clean" (fun _ ->
    CleanDir fcoreBuildDir
)

Target "Zip" (fun _ ->
    compressFile fcoreMklx86Dll
    compressFile fcoreMklx64Dll
)


Target "Build" (fun _ ->
    [fcoreProj]
      |> MSBuildRelease fcoreBuildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "BuildTests" (fun _ ->
    [fcoreTestsProj]
      |> MSBuildRelease "" "Build"
      |> Log "AppBuild-Output: "
)


Target "RunTests" (fun _ ->
    !! testAssemblies
    |> NUnit (fun p ->
        { p with
            DisableShadowCopy = true
            ToolPath = nunitPath
            TimeOut = TimeSpan.FromMinutes 20.
            OutputFile = "TestResults.xml" })
)


"Clean"
  ==> "Zip"
  ==> "Build"
  ==> "BuildTests"
  ==> "RunTests"

// start build
RunTargetOrDefault "RunTests"



