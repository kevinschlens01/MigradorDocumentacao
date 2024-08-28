using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class Receita
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string HashRegistro { get; set; }
        public string HashCliente { get; set; }
        public string? SblOrigem { get; set; }
        public int? SeqOrigem { get; set; }
        public string? NomOrigem { get; set; }
        public int? SeqDocumento { get; set; }
        public int? SeqCtOrcamento { get; set; }
        public int? SeqGgEmpresa { get; set; }
        public string? NomEmpresa { get; set; }
        public string? NroEmpresaCnpj { get; set; }
        public int? SeqGgFilial { get; set; }
        public string? NomFilial { get; set; }
        public string? NroFilialCnpj { get; set; }
        public string? SblReceita { get; set; }
        public string? NomReceita { get; set; }
        public string? SblDocumento { get; set; }
        public string? NomDocumento { get; set; }
        public string? NrdDocumento { get; set; }
        public int? AnoDocumento { get; set; }
        public DateTime? DatDocumento { get; set; }
        public string? MesDocumento { get; set; }
        public string? BolRedutora { get; set; }
        public int? SeqCtPlanoConta { get; set; }
        public string? CnoPlanoContaCategoria { get; set; }
        public string? CnoPlanoContaOrigem { get; set; }
        public string? CnoPlanoContaEspecie { get; set; }
        public string? CnoPlanoContaRubrica { get; set; }
        public string? CnoPlanoContaAlinea { get; set; }
        public string? CnoPlanoContaSubalinea { get; set; }
        public string? CnoPlanoConta { get; set; }
        public string? CnoFonteRecurso { get; set; }
        public int? SeqCtConvenio { get; set; }
        public string? AnoConvenio { get; set; }
        public string? NrdConvenio { get; set; }
        public decimal? VlrOrcamento { get; set; }
        public decimal? VlrDocumento { get; set; }
        public string? Ano { get; set; }
        public string? Mes { get; set; }
        public string? Anexo { get; set; }
        public string? NomMes { get; set; }
        public string? CodPlanoConta { get; set; }
        public string? NomPlanoConta { get; set; }
        public string? Dig1 { get; set; }
        public string? Dig2 { get; set; }
        public string? Dig3 { get; set; }
        public string? Dig4 { get; set; }
        public string? Dig5 { get; set; }
        public string? Dig6 { get; set; }
        public string? Dig7 { get; set; }
        public string? Dig8 { get; set; }
        public string? Dig9 { get; set; }
        public string? CodFonteRecurso1 { get; set; }
        public string? CodFonteRecurso2 { get; set; }
        public string? CodFonteRecurso { get; set; }
        public string? NomFonteRecurso { get; set; }
        public int? PortalGrupo { get; set; }
        public int? PortalGrupoE { get; set; }
        public int? EsferaAdministrativa { get; set; }
        public string? EsferaPoder { get; set; }
        public string? EsferaPoderTipo { get; set; }
        public string? EsferaPoderUg { get; set; }
        public string? CodigoTce { get; set; }
        public string? SblClassificacaoReceita { get; set; }
        public string? NomClassificacaoReceita { get; set; }
        public string? CompFonteRecurso { get; set; }
        public string? HashRegistroCpe { get; set; }
        public string? ControleCpe { get; set; }
    }
}
