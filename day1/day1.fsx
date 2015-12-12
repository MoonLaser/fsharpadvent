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
    match floor, basementFloor with
    | -1, -1 -> (floor + 1, position, position + 1)
    | _, _ -> (floor + 1, basementFloor, position + 1)
  | Down ->
    match floor, basementFloor with
    | -1, -1 -> (floor - 1, position, position + 1)
    | _, _ -> (floor - 1, basementFloor, position + 1))
    (0, -1, 0)
