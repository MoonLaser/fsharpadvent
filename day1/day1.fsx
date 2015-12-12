open System
open System.IO

let file = File.ReadAllLines("input.txt")
let result =
  Array.ofSeq (String.Join(String.Empty, file))
  |> Array.fold (fun acc elem -> if elem = '(' then acc + 1 else acc - 1) 0
