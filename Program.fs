namespace FSharp_comics
#nowarn "20"
open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open FSharp_comics.Endpoints

module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication.CreateBuilder(args)

        let app = builder.Build()

        app.MapGet("/comics", Func<string, IResult>(fun (_) -> GetAllComics.handler)) |> ignore

        app.Run()

        exitCode

