namespace FSharp_comics.Domains

module Comics =
    type Price = Price of float

    type T = {
        Title: string
        Price: Price
        Description: string   
    }
