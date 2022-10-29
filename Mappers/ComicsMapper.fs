namespace FSharp_comics.Mappers

open FSharp_comics.Domains
open FSharp_comics.Repositories

module ComicsMapper =
    let mapToDomain (dbRecord: sql.dataContext.``comics_shop.ComicsEntity``): Comics.T =
        {
            Title = dbRecord.Title;
            Price = dbRecord.Price |> Comics.Price;
            Description = dbRecord.Description;
        }
