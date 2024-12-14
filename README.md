# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing class properties before they're explicitly initialized.  In some cases, this might not immediately throw an exception, leading to unexpected behavior and making debugging difficult.

## The Problem

In C#, if you access a property of a class before assigning a value to it, it might return the property's default value (0 for integers, null for references, etc.) instead of throwing an exception. This can lead to incorrect results, especially in complex systems.

## Reproduction

The `bug.cs` file contains the problematic code. Running `MyMethod` will print the default value of `MyProperty`, not resulting in an error even though it's not been set. This behavior is not always obvious and can lead to hidden bugs.

## Solution

The `bugSolution.cs` file demonstrates a corrected version. By explicitly initializing `MyProperty` in the constructor, we ensure that it always has a defined value before access.  This approach promotes cleaner, more predictable behavior and avoids potential issues.