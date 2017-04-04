namespace Jacques.WebToSql

open FSharp.Data
open Jacques.WebToSql.DataModel
open System

module Parser =
    let HtmlToModel (httpResponse) =
        let html = HtmlDocument.Parse httpResponse

        // HTML contents
        let id = (html.CssSelect "input#hdnImovelID").Head.AttributeValue "value" |> int
        let bairro, cidade =
            try
                let logradouro = (html.CssSelect "div.side-left h1.pull-left span.logradouro").Head.InnerText()
                let bairro = (logradouro.Split ',').[0].Trim()
                let cidade = (logradouro.Split ',').[1].Trim()
                bairro, cidade
            with exn ->
                printfn "%A" exn
                "", ""
        let fotos = (html.CssSelect "div#myCarousel div.carousel-inner").Head.Elements() |> List.length
        let descricao = (html.CssSelect "div#descricaoOferta p").Head.InnerText()
        let valor = (((html.CssSelect "div.posvalue-imovel span.value-ficha").Head.Elements().Item 1).InnerText().Trim().Substring 3).Replace(".", "").Replace(",",".") |> float

        // Model
        let ap = new Apartamento()
        ap.ID <- id
        ap.DataExtracao <- DateTime.Now
        ap.Bairro <- bairro
        ap.Cidade <- cidade
        ap.Descricao <- descricao
        ap.Fotos <- fotos
        ap.Valor <- valor
        
        ap