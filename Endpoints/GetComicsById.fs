namespace FSharp_comics.Endpoints

open Microsoft.AspNetCore.Http
open FSharp_comics.Repositories
open FSharp_comics.Mappers
open System

module GetComicsById =
    let handler id =
        let c =
            ComicsRepo.getById id
            |> ComicsMapper.mapToDomain

        Results.Ok(c)
