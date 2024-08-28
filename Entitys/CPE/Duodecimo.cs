using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class Duodecimo
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string? HashRegistro { get; set; }
        public string? HashCliente { get; set; }
        public string? SblOrigem { get; set; }
        public string? NomOrigem { get; set; }
        public int? SeqOrigem { get; set; }
        public int? SeqGgEmpresa { get; set; }
        public string? NomEmpresa { get; set; }
        public string? NroEmpresaCnpj { get; set; }
        public int? SeqGgFilial { get; set; }
        public string? NomFilial { get; set; }
        public string? NroFilialCnpj { get; set; }
        public string? SblReceitaDespesa { get; set; }
        public string? NomReceitaDespesa { get; set; }
        public string? SblDocumento { get; set; }
        public string? NomDocumento { get; set; }
        public int? AnoDocumento { get; set; }
        public string? NrdDocumento { get; set; }
        public DateTime? DatDocumento { get; set; }
        public string? MesDocumento { get; set; }
        public string? BolRedutora { get; set; }
        public int? SeqCtPlanoConta { get; set; }
        public string? CnoPlanoContaClasse { get; set; }
        public string? CnoPlanoContaGrupo { get; set; }
        public string? CnoPlanoContaSubgrupo { get; set; }
        public string? CnoPlanoContaTitulo { get; set; }
        public string? CnoPlanoContaSubtitulo { get; set; }
        public string? CnoPlanoContaItem { get; set; }
        public string? CnoPlanoContaSubitem { get; set; }
        public string? CnoPlanoConta { get; set; }
        public string? CnoFonteRecurso { get; set; }
        public decimal? VlrReceita { get; set; }
        public decimal? VlrDespesa { get; set; }
        public int? NroLancamento { get; set; }
        public string? SblLancamentoDc { get; set; }
        public int? SeqGgPessoa { get; set; }
        public string? NroPessoaCpfCnpj { get; set; }
        public string? NomPessoa { get; set; }
        public string? Ano { get; set; }
        public string? Anexo { get; set; }
        public int? EsferaAdministrativa { get; set; }
        public string? EsferaPoder { get; set; }
        public string? EsferaPoderTipo { get; set; }
        public string? EsferaPoderUg { get; set; }
        public string? CodigoTce { get; set; }
        public string? CompFonteRecurso { get; set; }
        public string? HashRegistroCpe { get; set; }
        public string? ControleCpe { get; set; }
    }
}
