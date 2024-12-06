# C# NullReferenceException when accessing property member

This example demonstrates a common `NullReferenceException` in C# when attempting to access a member of a property that has not been initialized (is null).  The bug lies in the `MyMethod` function which tries to use a method from `MyProperty` which can be null. 

## Bug
The provided `bug.cs` file contains the erroneous code. The `MyMethod` attempts to call a method on the `MyProperty` which may not have been set leading to a null reference error.  The solution below shows how to fix the bug.

## Solution
The `bugSolution.cs` file offers a corrected version.  It includes a null check before accessing the member, which is a key step in preventing the `NullReferenceException`.
