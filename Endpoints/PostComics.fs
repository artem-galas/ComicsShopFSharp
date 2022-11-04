namespace FSharp_comics.Endpoints

open Microsoft.AspNetCore.Http
open FSharp_comics.Repositories
open FSharp_comics.Mappers

module PostComics =
    let handler data =
        let c =
            ComicsRepo.create(data)
            |> ComicsMapper.mapToDomain

        Results.Created($"/comics/{c.Id}", c)
