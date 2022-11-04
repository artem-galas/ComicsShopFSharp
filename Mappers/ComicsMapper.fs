namespace FSharp_comics.Mappers

open System
open FSharp_comics.Domains
open FSharp_comics.Repositories

module ComicsMapper =
    let mapToDomain (dbRecord: sql.dataContext.``comics_shop.ComicsEntity``): Comics.T =
        {
            Id =  dbRecord.Id;
            Title = dbRecord.Title;
            Price = dbRecord.Price;
            Description = dbRecord.Description;
        }
