using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class CompraOrdem
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? NomeTipoAf { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoOrdemCompra { get; set; }
        public DateTime? DataOrdemCompra { get; set; }
        public string? NomeModalidade { get; set; }
        public string? NumeroOrdemCompra { get; set; }
        public string? AnoOrdemCompra { get; set; }
        public string? NomeSituacao { get; set; }
        public string? CodigoSecretaria { get; set; }
        public string? NomeSecretaria { get; set; }
        public string? CodigoLocalRequerente { get; set; }
        public string? NomeLocalRequerente { get; set; }
        public string? CodigoLocalEntrega { get; set; }
        public string? NomeLocalEntrega { get; set; }
        public string? CodigoGFornecedor { get; set; }
        public string? NomeGFornecedor { get; set; }
        public string? NomeCpfCnpj { get; set; }
        public string? CpfCnpj { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? AnoProcesso { get; set; }
        public string? DescricaoOrdco { get; set; }
        public string? CodigoLicitacao { get; set; }
        public string? CodigoContrato { get; set; }
        public string? NomeMotivo { get; set; }
        public decimal? VlrTotal { get; set; }
        public string? DescricaoLicitacao { get; set; }
        public string? DescricaoContrato { get; set; }
        public string? NumeroArtigo { get; set; }
    }
}
