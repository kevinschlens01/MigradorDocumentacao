using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Convenio
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
        public string? TipoConvenio { get; set; }
        public string? NomeTipoConvenio { get; set; }
        public string? CodigoConvenio { get; set; }
        public string? CodigoConvenioAdtivo { get; set; }
        public string? NomeConvenio { get; set; }
        public string? NumeroAno { get; set; }
        public string? NumeroConvenio { get; set; }
        public string? AnoConvenio { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? AnoProcesso { get; set; }
        public string? ObjetoConvenio { get; set; }
        public string? CodigoOrgaoAdministracao { get; set; }
        public string? NomeOrgaoAdministracao { get; set; }
        public string? CodigoGConvenente { get; set; }
        public string? NomeGConvenente { get; set; }
        public string? NomeCpfCnpjConvenente { get; set; }
        public string? CpfCnpjConvenente { get; set; }
        public string? CodigoGResponsavel { get; set; }
        public string? NomeGResponsavel { get; set; }
        public string? NomeCpfCnpjResponsavel { get; set; }
        public string? CpfCnpjResponsavel { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public DateTime? DataAssinatura { get; set; }
        public DateTime? VigenciaInicial { get; set; }
        public DateTime? VigenciaFinal { get; set; }
        public string? ClassificacaoConvenio { get; set; }
        public string? NomeClassificacao { get; set; }
        public string? CodigoCategoria { get; set; }
        public string? NomeCategoria { get; set; }
        public string? NomeSituacaoContrato { get; set; }
        public string? TipoSituacaoContrato { get; set; }
        public string? CodigoUgTc { get; set; }
        public string? DescricaoContratoAditivo { get; set; }
        public decimal? VlrContPartida { get; set; }
        public decimal? VlrRepasse { get; set; }
        public decimal? VlrGlobal { get; set; }
        public decimal? VlrGlobalConvenioAditivo { get; set; }
    }
}
