module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let mutable c = int64 n
  let mutable m = 0
  while c <> 1L do
    if c % 2L = 0L then 
      c <- c / 2L
      m <- m + 1
    else 
      c <- (3L * c + 1L) / 2L
      m <- m + 2 
  m