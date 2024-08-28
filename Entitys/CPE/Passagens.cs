using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class Passagens
    {
        public int Id { get; set; }
        public int? PortalId { get; set; }
        public string? CodFilialHash { get; set; }
        public string? CodWebEmpenho { get; set; }
        public string? SblFase { get; set; }
        public string? NomFase { get; set; }
        public int? Ano { get; set; }
        public string? Mes { get; set; }
        public string? MesNum { get; set; }
        public string? NomFilial { get; set; }
        public string? NroFilialCnpj { get; set; }
        public string? NomDocumento { get; set; }
        public string? NrdDocumento { get; set; }
        public DateTime? DatDocumento { get; set; }
        public int? AnoProcesso { get; set; }
        public string? NrdProcesso { get; set; }
        public string? NomEmpenhoTipo { get; set; }
        public int? AnoEmpenho { get; set; }
        public string? NrdEmpenho { get; set; }
        public string? CnoOrgao { get; set; }
        public string? CnoUnidadeOrcamentaria { get; set; }
        public string? CnoFuncao { get; set; }
        public string? CnoSubfuncao { get; set; }
        public string? CnoPrograma { get; set; }
        public string? CnoAtividadeProjeto { get; set; }
        public string? CnoPlanoContaCategoria { get; set; }
        public string? CnoPlanoContaGrupo { get; set; }
        public string? CnoPlanoContaModalidade { get; set; }
        public string? CnoPlanoContaElemento { get; set; }
        public string? CnoPlanoConta { get; set; }
        public string? CnoFonteRecurso { get; set; }
        public string? NomPessoa { get; set; }
        public string? NroPessoaCpfCnpj { get; set; }
        public string? HstDocumento { get; set; }
        public decimal? VlrDocumento { get; set; }
        public string? CpfCnpjMask { get; set; }
        public string? NrdPagamento { get; set; }
        public string? CodWebPagamento { get; set; }
        public string? NomPagamentoTipo { get; set; }
        public string? NomCentroCusto { get; set; }
        public string? NnoPagamentoBancoDocumento { get; set; }
    }
}
