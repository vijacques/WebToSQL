open FSharp.Data
open Jacques.WebToSql.DataModel
open System.Net

[<EntryPoint>]
let main argv = 
    let client = new WebClient()
    client.Headers.Add("user-agent", "teste")

    let searchUrl = """https://www.zapimoveis.com.br/aluguel/apartamentos/rs+porto-alegre/#{"possuiendereco":"True","parametrosautosuggest":[{"Bairro":"","Zona":"","Cidade":"PORTO ALEGRE","Agrupamento":"","Estado":"RS"}],"pagina":"1","paginaOrigem":"Home","formato":"Lista"}"""
    
    let html = client.DownloadString searchUrl |> HtmlDocument.Parse
    let urlList = [for i in 0..19 do yield ((html.CssSelect ("a#miniFicha" + string i) |> List.head).AttributeValue "href").Replace("https", "http")]

    for url in urlList do
        printfn "%s" url

    // teste
    let url = "http://www.zapimoveis.com.br/oferta/aluguel+apartamento+3-quartos+moinhos-de-vento+porto-alegre+rs+105m2+RS2600/ID-9735810/"
    client.Headers.Add("user-agent", "teste")
    let resp = client.DownloadString url
    let html = HtmlDocument.Parse resp
    let logradouro = (html.CssSelect "div.side-left h1.pull-left span.logradouro" |> List.head).InnerText()

    let ap = new Apartamento()
    ap.Andares <- 5
    use db = new EntityContext()
    db.Database.EnsureDeleted() |> ignore
    db.Database.EnsureCreated() |> ignore
    db.Apartamentos.Add(ap) |> ignore
    db.SaveChanges() |> ignore

    0
