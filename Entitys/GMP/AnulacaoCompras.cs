using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class AnulacaoCompras
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? TipoAf { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoAnulacao { get; set; }
        public string? CodigoOrdemCompra { get; set; }
        public DateTime? DataAnualacao { get; set; }
        public string? NomeMotivoAnulacao { get; set; }
        public string? DescricaoAnulacao { get; set; }
    }
}
