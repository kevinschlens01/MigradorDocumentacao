using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class Diarias
    {
        public int Id { get; set; }
        public int? PortalId { get; set; }
        public string? HashPortalRegistro { get; set; }
        public string? HashCliente { get; set; }
        public int? SeqGgEmpresa { get; set; }
        public string? NomEmpresa { get; set; }
        public int? SeqCtUnidadeGestora { get; set; }
        public string? NomUnidadeGestora { get; set; }
        public string? NomUnidadeGestoraMunicipio { get; set; }
        public string? NomUnidadeGestoraEstado { get; set; }
        public string? NroUnidadeGestoraCnpj { get; set; }
        public int? SeqCtLiquidacaoDocumento { get; set; }
        public int? SeqCtLiquidacao { get; set; }
        public string? SblLiquidacaoDocumentoTipo { get; set; }
        public string? NroLiquidacaoDocumento { get; set; }
        public string? NomLiquidacaoDocumento { get; set; }
        public DateTime? DatLiquidacaoDocumento { get; set; }
        public decimal? VlrLiquidacaoDocumento { get; set; }
        public string? StrLiquidacaoDocumentoSerieNf { get; set; }
        public int? AnoLiquidacaoDocumentoReferencia { get; set; }
        public string? NroLiquidacaoDocumentoDiaria { get; set; }
        public string? NomLiquidacaoDocumentoFuncionario { get; set; }
        public DateTime? DatLiquidacaoDocumentoSaida { get; set; }
        public DateTime? DatLiquidacaoDocumentoRetorno { get; set; }
        public string? NroLiquidacaoDocumentoDanfe { get; set; }
        public string? NomMunicipio { get; set; }
        public int? EsferaAdministrativa { get; set; }
        public string? EsferaPoder { get; set; }
        public string? EsferaPoderTipo { get; set; }
        public string? EsferaPoderUg { get; set; }
        public string? CodigoTce { get; set; }
        public string? HashRegistroCpe { get; set; }
        public string? ControleCpe { get; set; }
        public string? IdLiquidacaoWeb { get; set; }
        public string? NomLiquidacaoDocumentoRjCargo { get; set; }
        public string? StrLiquidacaoDocumentoRjMotivoDiaria { get; set; }
    }
}
