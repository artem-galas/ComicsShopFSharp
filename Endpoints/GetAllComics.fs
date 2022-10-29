namespace FSharp_comics.Endpoints

open Microsoft.AspNetCore.Http
open FSharp_comics.Repositories
open FSharp_comics.Mappers
open FSharp.Data.Sql

module GetAllComics =
    let handler =
        let c =
            ComicsRepo.getList
                |> Seq.map ComicsMapper.mapToDomain
        
        Results.Ok(c)
