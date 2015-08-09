namespace lanef

open WebSharper
open WebSharper.JavaScript
open WebSharper.Html.Client

[<JavaScript>]
module Client =

    let Main =
        let welcome = P [Text "Welcome"]
        Div [
            welcome
            Button [Text "Click me"]
            |>! OnClick (fun e args ->
                welcome.Text <- "Salvete, sodales")
        ]
        |> fun res -> res.AppendTo "entrypoint"
