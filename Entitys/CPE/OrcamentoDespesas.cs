using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class OrcamentoDespesas
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string HashRegistro { get; set; }
        public string CodFilialHash { get; set; }
        public int? SeqGgEmpresa { get; set; }
        public string? NomEmpresa { get; set; }
        public string? NroEmpresaCnpj { get; set; }
        public int? SeqGgFilial { get; set; }
        public string? NomFilial { get; set; }
        public string? NroFilialCnpj { get; set; }
        public int? SeqCtOrcamento { get; set; }
        public int? AnoOrcamento { get; set; }
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
        public string? DscProgramaObjetivo { get; set; }
        public decimal? VlrOrcamento { get; set; }
        public string? Anexo { get; set; }
        public string? NomPlanoConta { get; set; }
        public string? CodPlanoConta { get; set; }
        public string? Dig1 { get; set; }
        public string? Dig2 { get; set; }
        public string? Dig3 { get; set; }
        public string? Dig4 { get; set; }
        public string? Dig5 { get; set; }
        public string? Dig6 { get; set; }
        public string? Dig7 { get; set; }
        public string? Dig8 { get; set; }
        public string? Dig9 { get; set; }
        public string? CodFuncao { get; set; }
        public string? NomFuncao { get; set; }
        public string? CodSubfuncao { get; set; }
        public string? NomSubfuncao { get; set; }
        public string? CodFonteRecurso1 { get; set; }
        public string? CodFonteRecurso2 { get; set; }
        public string? CodFonteRecurso { get; set; }
        public string? NomFonteRecurso { get; set; }
        public int? PortalGrupo { get; set; }
        public int? EsferaAdministrativa { get; set; }
        public string? EsferaPoder { get; set; }
        public string? EsferaPoderTipo { get; set; }
        public string? EsferaPoderUg { get; set; }
        public string? CodigoTce { get; set; }
        public string? CompFonteRecurso { get; set; }
        public string? HashRegistroCpe { get; set; }
        public string? ControleCpe { get; set; }
        public decimal? VlrOrcamentoAtualizado { get; set; }
        public int? SeqCtPrograma { get; set; }
    }
}
