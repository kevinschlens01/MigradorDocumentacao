using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class ContratoFiscal
    {
        public string? NomeTipoProcesso { get; set; }
        public string? HashRegistro { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? PortalId { get; set; }
        public string? CodigoContrato { get; set; }
        public string? NumeroContrato { get; set; }
        public int? AnoContrato { get; set; }
        public string? CodigoGFiscal { get; set; }
        public string? NomeGFiscal { get; set; }
        public string? CpfCnpjFiscal { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public string? NomeTipoFiscal { get; set; }
        public string? NomeAtoDesignacao { get; set; }
        public string? DescricaoTipoAtoOutros { get; set; }
        public string? NumeroAto { get; set; }
        public DateTime? DataAto { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string? NomeVeiculoPublicacao { get; set; }
        public string? DescricaoVeiculoPublicacao { get; set; }
        public string? EnderecoPublicacao { get; set; }
        public string? NomeSecre { get; set; }
    }
}
