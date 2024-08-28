using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class LicitacaoFornecedor
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoLicitacao { get; set; }
        public string? CodigoGFornecedor { get; set; }
        public string? NomeGFornecedor { get; set; }
        public string? NomeTipoDocumento { get; set; }
        public string? NumeroTipoDocumento { get; set; }
        public decimal? VlrTotalFornecedor { get; set; }
    }
}
