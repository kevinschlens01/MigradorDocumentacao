using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.TRB
{
    public class DividaAtiva
    {
        public string? PortalId { get; set; }
        public string? HashCliente { get; set; }
        public string? ClienteId { get; set; }
        public string? NomeGeral { get; set; }
        public string? NumeroDocumentoJuridico { get; set; }
        public int? Ano { get; set; }
        public int? Numero { get; set; }
        public string? SituacaoDivida { get; set; }
        public string? DescricaoAgrupamento { get; set; }
        public string? NomeTributo { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Correcao { get; set; }
        public decimal? Multa { get; set; }
        public decimal? Juros { get; set; }
        public decimal? Total { get; set; }
        public DateTime? DataAtualizacaoDivida { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? DescricaoContribuinteTipo { get; set; }
        public string? NomeTipoLogra { get; set; }
        public string? NomeLogradouro { get; set; }
        public string? NumeroLogradouro { get; set; }
        public string? ComplementoLogradouro { get; set; }
        public string? NomeBairro { get; set; }
        public string? NomeLocalidade { get; set; }
        public string? Cep { get; set; }
        public string? Chave { get; set; }
        public string? ChaveLancamento { get; set; }
        public string? ChaveItemTributo { get; set; }
    }
}
