using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Licitacao
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
        public string? CodigoLicitacao { get; set; }
        public string? ModalidadeLicitacao { get; set; }
        public string? NomeModalidade { get; set; }
        public string? NumeroLicitacao { get; set; }
        public string? AnoLicitacao { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? AnoProcesso { get; set; }
        public DateTime? AberturaLicitacao { get; set; }
        public TimeSpan? HoraLicitacao { get; set; }
        public string? ObjetoLicitacao { get; set; }
        public DateTime? DataHomologacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string? NomeArtigo { get; set; }
        public string? NumeroArtigo { get; set; }
        public decimal? ValorTotalHomologado { get; set; }
        public string? SituacaoLicitacao { get; set; }
        public string? NomeJulgamento { get; set; }
        public string? ValorPercentual { get; set; }
        public string? SeqCpLicitacaoDispensa { get; set; }
        public string? NomeLocalEntraExecucao { get; set; }
        public decimal? VlrEstimadoTotal { get; set; }
    }
}
