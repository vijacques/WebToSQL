open FSharp.Data
open Jacques.WebToSql.DataModel
open Jacques.WebToSql.Parser
open System
open System.Net

[<EntryPoint>]
let main argv = 
    use db = new EntityContext()
    db.Database.EnsureDeleted() |> ignore
    db.Database.EnsureCreated() |> ignore

    let mutable counter = 0

    let doWork url =
        async {
            let! resp = Http.AsyncRequestString(url, headers = [("user-agent","teste")])
            let ap, id = HtmlToModel resp
            db.Apartamentos.Add(ap) |> ignore
            counter <- counter + 1
            printfn "\t%i ID:%i" counter id
        }

    for i in 1..2 do
        let searchUrl = """https://www.zapimoveis.com.br/aluguel/apartamentos/rs+porto-alegre/#{"possuiendereco":"True","parametrosautosuggest":[{"Bairro":"","Zona":"","Cidade":"PORTO ALEGRE","Agrupamento":"","Estado":"RS"}],"pagina":""" + "\"" + string i + "\"" + ""","paginaOrigem":"Home","formato":"Lista"}"""
        printfn "%i %s" i searchUrl

        let content = Http.RequestString(searchUrl, headers = [("user-agent","teste")])
        let html = HtmlDocument.Parse content
        let urlList = [for i in 0..19 do yield ((html.CssSelect ("a#miniFicha" + string i) |> List.head).AttributeValue "href").Replace("https", "http")]

        urlList |> Seq.map doWork |> Async.Parallel |> Async.RunSynchronously |> ignore

        db.SaveChanges() |> ignore
    
    Console.ReadLine() |> ignore
    0