namespace FSharp_comics.Domains

open System

module Comics =

    type T = {
        Id: string
        Title: string
        Price: float
        Description: string   
    }
