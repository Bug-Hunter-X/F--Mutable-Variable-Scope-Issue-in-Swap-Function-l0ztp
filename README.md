# F# Mutable Variable Scope Issue

This example demonstrates a common issue in F# related to the scope and mutability of variables within functions.  The `swap` function correctly swaps the values of mutable variables, while `swap2` fails to compile due to attempting to modify immutable values.

The `bug.fs` file contains the buggy code. The `bugSolution.fs` file provides a corrected approach using tuples, avoiding the mutation issues and resulting compile errors.