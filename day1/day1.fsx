open System
open System.IO

type Movement =
  | Up
  | Down

let file = File.ReadAllLines("input.txt")
let directions = Array.ofSeq (String.Join(String.Empty, file)) |> Array.map (fun x -> if x = '(' then Up else Down)
let result =
  directions
  |> Array.fold (fun (floor, basementFloor, position) elem ->
  match elem with
  | Up ->
      if floor = -1 && basementFloor = -1 then
        (floor + 1, position, position + 1)
      else
        (floor + 1, basementFloor, position + 1)
  | Down ->
      if floor = -1 && basementFloor = -1 then
        (floor - 1, position, position + 1)
      else
        (floor - 1, basementFloor, position + 1))
    (0, -1, 0)
