using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class AnulacaoItens
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? TipoAf { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpesa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoAnulacao { get; set; }
        public string? CodigoOrdemCompra { get; set; }
        public string? CodigoOrdcoitem { get; set; }
        public int? CodigoItemAnulacao { get; set; }
        public string? TipoCompra { get; set; }
        public string? CodigoProdServi { get; set; }
        public string? NomeProdServi { get; set; }
        public string? DescricaoItemAnulacao { get; set; }
        public string? CodigoEmbalagem { get; set; }
        public string? NomeEmbalagem { get; set; }
        public string? AbreviaturaEmbalagem { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? VlrUnitario { get; set; }
        public decimal? VlrTotal { get; set; }
    }
}
