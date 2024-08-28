using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class OrdemCronologica
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string? HashRegistro { get; set; }
        public string CodFilialHash { get; set; }
        public int? SeqTmpOrdemLiquidacao { get; set; }
        public int? SeqCtUnidadeGestora { get; set; }
        public string? NomUnidadeGestora { get; set; }
        public int? SeqCtOrdem { get; set; }
        public int? NroOrdem { get; set; }
        public string? NomOrdem { get; set; }
        public string? CnoOrdem { get; set; }
        public int? NroOrdemGeralFila { get; set; }
        public int? NroOrdemFila { get; set; }
        public int? SeqCtLiquidacao { get; set; }
        public string? NroLiquidacao { get; set; }
        public DateTime? DatLiquidacao { get; set; }
        public string? AnoDocumento { get; set; }
        public string? MesDocumento { get; set; }
        public DateTime? DatLiquidacaoVencimento { get; set; }
        public string? HstLiquidacao { get; set; }
        public decimal? VlrLiquidacao { get; set; }
        public int? SeqCtPagamento { get; set; }
        public string? NroPagamentoOrdem { get; set; }
        public string? NroPagamento { get; set; }
        public string? NomPessoa { get; set; }
        public string? DocPessoaCpfCnpj { get; set; }
        public string? NroEmpenho { get; set; }
        public string? CnoEmpenhoTipo { get; set; }
        public string? CodFonteRecursoTce { get; set; }
        public string? NomFonteRecursoTce { get; set; }
        public string? CnoFonteRecursoTce { get; set; }
        public string? SblContratoTipo { get; set; }
        public string? NomContratoTipo { get; set; }
        public string? CnoContratoTipo { get; set; }
        public string? NdaContrato { get; set; }
        public string? CnoLicitacaoModalidade { get; set; }
        public string? NdaLicitacao { get; set; }
        public string? NnrLicitacao { get; set; }
        public string? NomLicitacaoClassificacao { get; set; }
        public string? CnoLicitacaoClassificacao { get; set; }
        public decimal? SldLiquidacaoOrdemFinal { get; set; }
        public decimal? SldLiquidacaoPagarFinal { get; set; }
        public string? SblTipoOrdem { get; set; }
        public string? CodWebEmpenho { get; set; }
        public string? CodWebLiquidacao { get; set; }
        public string? CodWebPagamento { get; set; }
        public string? MotivoQuebraOrdemCronologica { get; set; }
        public int? NroLiquidacaoProcesso { get; set; }
    }
}
