module sampleapp.HtmlViews


open Giraffe.ViewEngine
open sampleapp.Models

let layout (content: XmlNode list) =
    html [] [
        head [] [ title [] [ str "Girafe" ] ]
        body [] content
    ]

let partial () = p [] [ str "Some partial text." ]

let personView (model: Person) =
    [ div [ _class "container" ] [
        h3 [ _title "Some title attribute" ] [
            sprintf "Hello, %s" model.Name |> str
        ]
        a [ _href "https://github.com/giraffe-fsharp/Giraffe" ] [
            str "GitHub"
        ]
      ]
      div [] [ partial () ] ]
    |> layout
