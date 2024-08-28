using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Almoxarifado
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
        public string? CodigoAlmox { get; set; }
        public string? NomeAlmox { get; set; }
        public int? CodigoDocumento { get; set; }
        public string? AnoMovimento { get; set; }
        public DateTime? DataMovimento { get; set; }
        public DateTime? DataNotaFiscal { get; set; }
        public string? CodigoForneLocal { get; set; }
        public string? NomeForneLocal { get; set; }
        public string? NomeTipoDocumento { get; set; }
        public string? NumeroTipoDocumento { get; set; }
        public string? NumeroNotaFiscal { get; set; }
        public string? CodigoFicha { get; set; }
        public string? NomeFicha { get; set; }
        public string? TipoMovimento { get; set; }
        public string? NomeTipoMovimento { get; set; }
        public string? DescricaoEntraSaida { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
