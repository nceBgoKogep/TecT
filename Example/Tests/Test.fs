module Tests

open NUnit.Framework
open Useful

[<TestFixture>]
type Test () =
    
    [<Test>]
    member _.testKillerFunction () =
        Assert.AreEqual (killerFunction (), ())