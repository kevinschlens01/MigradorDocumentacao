using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class LicitacoDetalhe
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoLicitacao { get; set; }
        public string? CodigoLicitacaoItem { get; set; }
        public string? CodigoGFornecedor { get; set; }
        public string? NomeGFornecedor { get; set; }
        public string? NomeTipoDocumento { get; set; }
        public string? NumeroTipoDocumento { get; set; }
        public int? ItemLicititem { get; set; }
        public int? CodigoLote { get; set; }
        public string? NomeLote { get; set; }
        public string? ProdutoServico { get; set; }
        public string? NomeProdutoServico { get; set; }
        public string? DescricaoProdutoServico { get; set; }
        public string? NomeEmbalagem { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? VlrUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
        public DateTime? DataAberturaCompra { get; set; }
    }
}
