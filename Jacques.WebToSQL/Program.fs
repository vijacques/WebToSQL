open FSharp.Data
open Jacques.WebToSql.DataModel
open Jacques.WebToSql.Parser
open System.Net

[<EntryPoint>]
let main argv = 
    // TODO: change to FSharp.Data client? check user-agent header
    let client = new WebClient()
    client.Headers.Add("user-agent", "teste")

    let searchUrl = """https://www.zapimoveis.com.br/aluguel/apartamentos/rs+porto-alegre/#{"possuiendereco":"True","parametrosautosuggest":[{"Bairro":"","Zona":"","Cidade":"PORTO ALEGRE","Agrupamento":"","Estado":"RS"}],"pagina":"1","paginaOrigem":"Home","formato":"Lista"}"""
    
    let html = client.DownloadString searchUrl |> HtmlDocument.Parse
    let urlList = [for i in 0..19 do yield ((html.CssSelect ("a#miniFicha" + string i) |> List.head).AttributeValue "href").Replace("https", "http")]

    use db = new EntityContext()
    db.Database.EnsureDeleted() |> ignore
    db.Database.EnsureCreated() |> ignore

    for url in urlList do
        client.Headers.Add("user-agent", "teste")
        let resp = client.DownloadString url
        let ap = HtmlToModel resp
        
        db.Apartamentos.Add(ap) |> ignore
        printfn "%s" url

    db.SaveChanges() |> ignore
    0