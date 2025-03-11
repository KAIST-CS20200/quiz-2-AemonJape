module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec collatz m n =
    if n = 1L then m
    elif n % 2L = 0L then collatz (m+1) (n/2L)
    else collatz (m+2) ((3L*n+1L)/2L)
  collatz 0 (int64 n)