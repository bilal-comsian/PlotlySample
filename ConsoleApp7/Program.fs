// Learn more about F# at http://fsharp.org

open System
open Plotly.NET

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    

    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y = [10.; 20.; 30.; 40.; 50.; 60.; 70.; 86.; 95.; 100.]
    let line1 =
        Chart.Line(
            x,y,
            Name="line",
            ShowMarkers=true,
            MarkerSymbol=StyleParam.Symbol.Square)    
        |>Chart.withX_AxisStyle("X-axis")
        |>Chart.withY_AxisStyle("Y-axis")
        |> Chart.withLineStyle(Width=2.,Dash=StyleParam.DrawingStyle.Solid) 
        |> Chart.Show
    
    0 // return an integer exit code
