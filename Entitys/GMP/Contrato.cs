using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Contrato
    {
        public string? TipoProcesso { get; set; }
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoContrato { get; set; }
        public string? CodigoContratoAdtivo { get; set; }
        public string? NumeroAno { get; set; }
        public string? NumeroContrato { get; set; }
        public string? AnoContrato { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? AnoProcesso { get; set; }
        public string? ObjetoContrato { get; set; }
        public DateTime? DataAssinatura { get; set; }
        public string? CodigoOrgaoAdministracao { get; set; }
        public string? NomeOrgaoAdiministracao { get; set; }
        public string? CodigoLicitacao { get; set; }
        public string? NumeroAnoLicit { get; set; }
        public string? NomeModalidade { get; set; }
        public string? CodigoGFornecedor { get; set; }
        public string? NomeGFornecedor { get; set; }
        public string? NomeCpfCnpj { get; set; }
        public string? CpfCnpj { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public DateTime? VigenciaInicial { get; set; }
        public DateTime? VigenciaFinal { get; set; }
        public decimal? ValorGlobal { get; set; }
        public string? CodigoUgTc { get; set; }
        public string? CodigoCategoria { get; set; }
        public string? NomeCategoria { get; set; }
        public string? NomeSituacaoContrato { get; set; }
        public string? TipoSituacaoContrato { get; set; }
        public string? NomeMotivo { get; set; }
        public string? NumeroMotivo { get; set; }
    }
}
