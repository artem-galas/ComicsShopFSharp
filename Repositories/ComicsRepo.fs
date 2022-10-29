namespace FSharp_comics.Repositories

open FSharp.Data.Sql

type sql = SqlDataProvider<
                Common.DatabaseProviderTypes.MYSQL,
                "server=127.0.0.1;port=8091;database=comics_shop;user=comics_shop;password=password">

module ComicsRepo =
    let ctx = sql.GetDataContext()

    let getList =
        query {
            for c in ctx.ComicsShop.Comics do
            select c
        }