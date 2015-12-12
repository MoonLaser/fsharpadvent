open System
open System.IO

let file = File.ReadAllLines("input.txt")
let charArray = Array.ofSeq (String.Join(String.Empty, file))
let result =
  charArray
  |> Array.fold (fun (floor, basementFloor, position) elem ->
    if elem = '(' then
      if floor = -1 && basementFloor = -1 then
        (floor + 1, position, position + 1)
      else
        (floor + 1, basementFloor, position + 1)
    else
      if floor = -1 && basementFloor = -1 then
        (floor - 1, position, position + 1)
      else
        (floor - 1, basementFloor, position + 1))
    (0, -1, 0)
