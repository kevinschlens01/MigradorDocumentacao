using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class BemImovelDetalhe
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
        public string? CodigoDocumento { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public decimal? AreaTotal { get; set; }
        public string? UnidadeArea { get; set; }
        public string? ImovelProprio { get; set; }
        public string? ZonaImovel { get; set; }
        public string? NomeTpl { get; set; }
        public string? NomeLogra { get; set; }
        public string? Numero { get; set; }
        public string? NomeBairr { get; set; }
        public string? NomeMunic { get; set; }
        public string? SiglaEstad { get; set; }
        public string? CepLogra { get; set; }
        public string? Complemento { get; set; }
        public string? NomeUsoImov { get; set; }
        public string? Utilizacao { get; set; }
        public string? Observacao { get; set; }
        public decimal? LatitudeGraus { get; set; }
        public decimal? LatitudeMinutos { get; set; }
        public decimal? LatitudeSegundos { get; set; }
        public decimal? LatitudeSentido { get; set; }
        public decimal? LongitudeGraus { get; set; }
        public decimal? LongitudeMinutos { get; set; }
        public decimal? LongitudeSegundos { get; set; }
        public decimal? LongitudeSentido { get; set; }
        public string? NomeSituacaoBem { get; set; }
        public DateTime? DataAvaliacao { get; set; }
        public decimal? ValorAvaliacao { get; set; }
        public DateTime? DataAquisicao { get; set; }
    }
}
