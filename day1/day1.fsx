open System
open System.IO

let mutable floor = 0
let file = File.ReadAllLines("input.txt")
let charArray = Array.ofSeq (String.Join(String.Empty, file))
for i in charArray do
  if i = '(' then floor <- floor + 1 else floor <- floor - 1
