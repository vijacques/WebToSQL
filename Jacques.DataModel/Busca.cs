using System.Collections.Generic;

namespace Jacques.DataModel
{
    public class ParametrosAutoSuggest
    {
        public string Agrupamento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CodAgrupamento { get; set; }
        public string CodBairro { get; set; }
        public string CodCidade { get; set; }
        public string CodCliente { get; set; }
        public string CodEstado { get; set; }
        public string CodZona { get; set; }
        public string Estado { get; set; }
        public string NomeCliente { get; set; }
        public string Zona { get; set; }
    }

    public class ResponseStatus
    {
        public string ErrorCode { get; set; }
        public string Errors { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }

    public class Foto
    {
        public int Altura { get; set; }
        public string Descricao { get; set; }
        public int Largura { get; set; }
        public int Origem { get; set; }
        public bool Principal { get; set; }
        public int TipoOferta { get; set; }
        public string UrlImagem { get; set; }
        public string UrlImagemTamanhoG { get; set; }
        public string UrlImagemTamanhoGG { get; set; }
        public string UrlImagemTamanhoM { get; set; }
        public string UrlImagemTamanhoP { get; set; }
        public string UrlImagemTamanhoPP { get; set; }
    }

    public class Resultado2
    {
        public string AnuncianteTipo { get; set; }
        public string ApresentarLinkEntrarEmContato { get; set; }
        public int Area { get; set; }
        public string AreaFormatada { get; set; }
        public int AreaMaxima { get; set; }
        public int AreaMinima { get; set; }
        public string Bairro { get; set; }
        public string BairroOficial { get; set; }
        public string BlackList { get; set; }
        public string CEP { get; set; }
        public string Categoria { get; set; }
        public string Cidade { get; set; }
        public string CidadeOficial { get; set; }
        public string ClassBotaoFavorito { get; set; }
        public int CodCampanhaImovel { get; set; }
        public int CodImobiliaria { get; set; }
        public int CodigoAnunciante { get; set; }
        public string CodigoOfertaImobiliaria { get; set; }
        public int CodigoOfertaZAP { get; set; }
        public int CodigoUsuario { get; set; }
        public string ContatoCampanha { get; set; }
        public string DataAtualizacaoHumanizada { get; set; }
        public string DetalhesOferta { get; set; }
        public string DistanciaMetro { get; set; }
        public string DistanciaOnibus { get; set; }
        public string DistanciaTrabalho { get; set; }
        public string Empreendimento { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public int EstagioObra { get; set; }
        public bool ExibirNotaAnuncio { get; set; }
        public string FormatarSubTipoImovel { get; set; }
        public string FormatarSubTipoOferta { get; set; }
        public List<Foto> Fotos { get; set; }
        public string FotosOfertas { get; set; }
        public string FotosSerializadas { get; set; }
        public string FuncaoOnclickBotaoFavorito { get; set; }
        public string IdFavorito { get; set; }
        public string IdSchema { get; set; }
        public bool IndBloqueadoBlackListOPEC { get; set; }
        public bool IndDistrato { get; set; }
        public bool IndSitePersonalizado { get; set; }
        public bool IndUsuarioOPEC { get; set; }
        public string IndiceContatoCampanha { get; set; }
        public double Latitude { get; set; }
        public string LogNota { get; set; }
        public double Longitude { get; set; }
        public string MensagemContatePadrao { get; set; }
        public string NomeAnunciante { get; set; }
        public double Nota { get; set; }
        public string Observacao { get; set; }
        public string ObterMensagemToolTipTrabalho { get; set; }
        public bool OcultadoPeloVisitante { get; set; }
        public string OrigemLead { get; set; }
        public bool PaginaAnunciante { get; set; }
        public string PosicaoRB { get; set; }
        public bool PossuiQualidadeTotal { get; set; }
        public string PrecoCondominio { get; set; }
        public string PrecoVendaMaximo { get; set; }
        public string PrecoVendaMinimo { get; set; }
        public List<object> ProdutosParceiros { get; set; }
        public int QuantidadeQuartos { get; set; }
        public string QuantidadeQuartosFormatada { get; set; }
        public int QuantidadeQuartosMaxima { get; set; }
        public int QuantidadeQuartosMinima { get; set; }
        public int QuantidadeSuites { get; set; }
        public string QuantidadeSuitesFormatada { get; set; }
        public int QuantidadeSuitesMaxima { get; set; }
        public int QuantidadeSuitesMinima { get; set; }
        public int QuantidadeVagas { get; set; }
        public string QuantidadeVagasFormatada { get; set; }
        public int QuantidadeVagasMaxima { get; set; }
        public int QuantidadeVagasMinima { get; set; }
        public int SubTipo { get; set; }
        public string SubTipoImovel { get; set; }
        public string SubTipoOferta { get; set; }
        public List<object> Telefones { get; set; }
        public int Tipo { get; set; }
        public string TipoDaOferta { get; set; }
        public string TituloPagina { get; set; }
        public string Transacao { get; set; }
        public string URLAtendimento { get; set; }
        public string UrlFicha { get; set; }
        public string UrlFotoDestaqueTamanhoM { get; set; }
        public string UrlFotoDestaqueTamanhoP { get; set; }
        public string UrlLogotipoCliente { get; set; }
        public bool UtilizarChatParceiro { get; set; }
        public string Valor { get; set; }
        public string ValorIPTU { get; set; }
        public bool VerificarExibicaoUrlLogoCliente { get; set; }
        public string ZapID { get; set; }
        public string funcaoOnClickEntrarEmContato { get; set; }
        public string funcaoOnClickVerTelefone { get; set; }
        public bool possuiChat { get; set; }
        public bool possuiEmail { get; set; }
        public bool possuiTelefone { get; set; }
    }

    public class SitePersonalizado
    {
        public string AreaAtuacao { get; set; }
        public string CodigoCliente { get; set; }
        public string Creci { get; set; }
        public bool IndSitePersonalizado { get; set; }
        public string LogoCliente { get; set; }
        public string NomeCliente { get; set; }
        public string TextoInstitucional { get; set; }
    }

    public class Resultado1
    {
        public string AreaTotalMaxima { get; set; }
        public string AreaTotalMinima { get; set; }
        public string AreaUtilMaxima { get; set; }
        public string AreaUtilMinima { get; set; }
        public bool AtivarNovoResultadoZero { get; set; }
        public string BairroOficialResultadoBusca { get; set; }
        public string Caracteristica { get; set; }
        public string CidadeOficialResultadoBusca { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoOferta { get; set; }
        public string Contate { get; set; }
        public string CriteriosAutoSuggest { get; set; }
        public string DebugNota { get; set; }
        public string DescricaoPagina { get; set; }
        public string EnderecoTrabalho { get; set; }
        public string FiltroDormitorios { get; set; }
        public string FiltroSuites { get; set; }
        public string FiltroVagas { get; set; }
        public int Formato { get; set; }
        public string FotosOfertas { get; set; }
        public string GrupoNavegadores { get; set; }
        public string IndDistrato { get; set; }
        public bool IndExecutaResultadoZero { get; set; }
        public bool IndResultadoCampanha { get; set; }
        public bool IndResultadoZero { get; set; }
        public bool IndSitePersonalizado { get; set; }
        public int IndicePosicaoBanner { get; set; }
        public string JsonLD { get; set; }
        public double Latitude { get; set; }
        public string LatitudeRuaPOI { get; set; }
        public string ListaSubtiposLocacao { get; set; }
        public string ListaSubtiposVenda { get; set; }
        public string Localizacao { get; set; }
        public double Longitude { get; set; }
        public string LongitudeRuaPOI { get; set; }
        public string Navegadores { get; set; }
        public string NomeCliente { get; set; }
        public string NomeImobiliariaBusca { get; set; }
        public string Observacao { get; set; }
        public string ObterSugestaoZero { get; set; }
        public int Ordenacao { get; set; }
        public string POI { get; set; }
        public string POICompleta { get; set; }
        public int PaginaAtual { get; set; }
        public string PaginaAtualFormatado { get; set; }
        public int PaginaOrigem { get; set; }
        public List<ParametrosAutoSuggest> ParametrosAutoSuggest { get; set; }
        public bool PossuiEndereco { get; set; }
        public string PossuiFotos { get; set; }
        public string PrecoCondominio { get; set; }
        public long PrecoMaximo { get; set; }
        public string PrecoMinimo { get; set; }
        public int QuantidadePaginas { get; set; }
        public string QuantidadePaginasFormatado { get; set; }
        public int QuantidadeRegistros { get; set; }
        public string QuantidadeRegistrosFormatado { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public List<Resultado2> Resultado { get; set; }
        public string SemFiador { get; set; }
        public string Semente { get; set; }
        public SitePersonalizado SitePersonalizado { get; set; }
        public string SubTipoImovel { get; set; }
        public int SubTipoOferta { get; set; }
        public string SugestoesResultadoZero { get; set; }
        public List<object> Tags { get; set; }
        public string TextoBuscaAberta { get; set; }
        public string TextoQuantidadeResultados { get; set; }
        public int TipoAnunciante { get; set; }
        public List<int> TiposOrdenacao { get; set; }
        public string TituloBusca { get; set; }
        public string TituloPagina { get; set; }
        public int Transacao { get; set; }
        public string ValorIPTU { get; set; }
    }

    public class Breadcrumb
    {
        public int Ordem { get; set; }
        public string TextoAmigavel { get; set; }
        public string Url { get; set; }
    }

    public class Silo2
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Conteudo { get; set; }
        public string DescricaoLink { get; set; }
        public string Dormitorios { get; set; }
        public string Estado { get; set; }
        public int NumeroDoModulo { get; set; }
        public int QuantidadeOfertas { get; set; }
        public string TextoAmigavel { get; set; }
        public string Tipo { get; set; }
        public int TipoSiloRetornado { get; set; }
        public int Transacao { get; set; }
        public string URL { get; set; }
        public string Url { get; set; }
        public string Zona { get; set; }
    }

    public class Silo
    {
        public int NumeroModulo { get; set; }
        public int NumeroOfertas { get; set; }
        public List<Silo2> Silos { get; set; }
        public string TituloModulo { get; set; }
        public string Url { get; set; }
    }

    public class RootObject
    {
        public string FaixaPrecoModalAlerta { get; set; }
        public string Formato { get; set; }
        public bool IsContabilizarAssincrono { get; set; }
        public bool IsPaginaAnunciante { get; set; }
        public Resultado1 Resultado { get; set; }
        public string TituloModalAlerta { get; set; }
        public List<Breadcrumb> breadcrumb { get; set; }
        public List<Silo> silos { get; set; }
    }

}
