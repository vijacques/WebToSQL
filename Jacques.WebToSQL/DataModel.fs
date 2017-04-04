namespace Jacques.WebToSql.DataModel

open Microsoft.EntityFrameworkCore

type Apartamento() =
    member val ID = 0 with get,set
    member val Valor = 0.f with get,set
    member val Quartos = 0 with get,set
    member val Suites = 0 with get,set
    member val Area_Util = 0 with get,set
    member val Area_Total = 0 with get,set
    member val Vagas = 0 with get,set
    member val Condominio = 0 with get,set
    member val IPTU = 0.f with get,set
    member val Bairro = "" with get,set
    member val Rua = "" with get,set
    member val Cidade = "" with get,set
    member val Fotos = 0 with get,set
    member val Descricao = "" with get,set
    member val Ano_Construcao = 0 with get,set
    member val Caracteristicas_Imovel = "" with get,set
    member val Caracteristicas_Areas_Comuns = "" with get,set
    member val Andares = 0 with get,set

type EntityContext() =
    inherit DbContext()

    member x.Apartamentos = x.Set<Apartamento>()

    override x.OnConfiguring(optionsBuilder) =
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;") |> ignore

    override x.OnModelCreating(modelBuilder) =
        modelBuilder.Entity<Apartamento>().HasKey("ID") |> ignore
        ()