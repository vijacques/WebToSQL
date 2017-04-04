namespace Jacques.WebToSql

open Microsoft.EntityFrameworkCore
open System

module DataModel =
    type Apartamento() =
        member val ID = 0 with get,set
        member val DataExtracao = DateTime.MinValue with get,set
        member val Valor = float 0 with get,set
        member val Quartos = 0 with get,set
        member val Suites = 0 with get,set
        member val AreaUtil = 0 with get,set
        member val AreaTotal = 0 with get,set
        member val Vagas = 0 with get,set
        member val Condominio = 0 with get,set
        member val IPTU = float 0 with get,set
        member val Bairro = "" with get,set
        member val Rua = "" with get,set
        member val Cidade = "" with get,set
        member val Fotos = 0 with get,set
        member val Descricao = "" with get,set
        member val AnoConstrucao = 0 with get,set
        member val CaracteristicasImovel = "" with get,set
        member val CaracteristicasAreasComuns = "" with get,set
        member val Andares = 0 with get,set

    type EntityContext() =
        inherit DbContext()

        member x.Apartamentos = x.Set<Apartamento>()

        override x.OnConfiguring(optionsBuilder) =
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TC;Trusted_Connection=True;") |> ignore

        override x.OnModelCreating(modelBuilder) =
            modelBuilder.Entity<Apartamento>().HasKey("ID", "DataExtracao") |> ignore
            ()