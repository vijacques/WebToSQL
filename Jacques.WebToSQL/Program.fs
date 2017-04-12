open Jacques.DataModel
open Jacques.WebToSql.DataModel
open Jacques.WebToSql.Parser
open Newtonsoft.Json
open System
open System.IO

[<EntryPoint>]
let main argv = 
    use db = new EntityContext()
    db.Database.EnsureDeleted() |> ignore
    db.Database.EnsureCreated() |> ignore

    let path = "C:/Users/Vinicius Jacques/Source/phantomjs-2.1.1-windows/bin/"

    for file in Directory.EnumerateFiles(path, "*.txt") do
        try
            let content = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText file)

            for resultado in content.Resultado.Resultado do
                let ap = new Apartamento()
                ap.ID <- resultado.CodigoOfertaZAP
                // area total? area util?
                ap.Area <- resultado.Area
                ap.Rua <- resultado.Endereco
                ap.Bairro <- resultado.Bairro
                ap.Cidade <- resultado.Cidade
                ap.CEP <- string resultado.CEP
                ap.Endereco <- resultado.Endereco
                ap.Estado <- resultado.Estado
                ap.Fotos <- resultado.Fotos.Count
                ap.Descricao <- resultado.Observacao
                ap.Condominio <- float (resultado.PrecoCondominio.Replace("R$ ", "").Replace(".","").Replace(",","."))
                ap.Quartos <- resultado.QuantidadeQuartos
                ap.Suites <- resultado.QuantidadeSuites
                ap.Vagas <- resultado.QuantidadeVagas
                ap.Valor <- float (resultado.Valor.Replace("R$ ", "").Replace(".","").Replace(",","."))
                ap.IPTU <- float (resultado.ValorIPTU.Replace("R$ ", "").Replace(".","").Replace(",","."))
                ap.DataExtracao <- Directory.GetLastWriteTime file
                ap.DataAtualizacaoHumana <- resultado.DataAtualizacaoHumanizada
                // ano construcao? CaracteristicasImovel? CaracteristicasAreasComuns? Andares?

                db.Apartamentos.Add ap |> ignore
            printfn "Finished file: %s" file
            db.SaveChanges() |> ignore
        with exn -> printfn "%A" exn

    Console.ReadLine() |> ignore
    0