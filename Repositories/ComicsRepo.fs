namespace FSharp_comics.Repositories

open FSharp.Data.Sql
open System

type sql = SqlDataProvider<
                Common.DatabaseProviderTypes.MYSQL,
                "server=127.0.0.1;port=8091;database=comics_shop;user=comics_shop;password=password">

module ComicsRepo =
    let private ctx = sql.GetDataContext()

    let private ComicsTable = ctx.ComicsShop.Comics;

    type ComicsRequestDto = {
        Title: string
        Price: float
        Description: string
    }

    let getList =
        query {
            for c in ctx.ComicsShop.Comics do
            select c
        }

    let getById id =
        query {
            for c in ComicsTable do
            where (c.Id = id)
            select c
        } |> Seq.head

    let create data =
        let id = Guid.NewGuid().ToString()
        let row = ComicsTable.Create()
        row.Id <- id
        row.Title <- data.Title
        row.Price <- data.Price
        row.Description <- data.Description

        ctx.SubmitUpdates()

        row