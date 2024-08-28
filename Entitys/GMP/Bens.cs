using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Bens
    {
        public string? PortalId { get; set; }
        public string? HashRegistro { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? CodigoTipoBem { get; set; }
        public string? NomeTipoBem { get; set; }
        public string? TipoBem { get; set; }
        public string? CodigoDocumento { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public string? NomePatrimonio { get; set; }
        public string? DescricaoPatrimonio { get; set; }
        public string? CodigoTipoAquisicaoBaixa { get; set; }
        public string? NomeTipoIncorporacaoBaixa { get; set; }
        public DateTime? DataIncorporacaoBaixa { get; set; }
        public string? NumeroDocumentoAquisicao { get; set; }
        public string? CodigoClasse { get; set; }
        public string? NomeClasse { get; set; }
        public string? CodPlanoConta { get; set; }
        public string? NomePlanoConta { get; set; }
        public string? CodigoLocalAquisicao { get; set; }
        public string? NomeLocalAquisicao { get; set; }
        public string? CodigoLocalAtual { get; set; }
        public string? NomeLocalAtual { get; set; }
        public decimal? ValorAquisicao { get; set; }
        public decimal? ValorAtualBaixa { get; set; }
        public string? NomeGResponsavel { get; set; }
    }
}
