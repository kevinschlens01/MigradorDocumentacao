using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Documentos
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
        public string? CodigoProcesso { get; set; }
        public int? TipoDocumentoPortal { get; set; }
        public string? NomeTipoDocumentoPortal { get; set; }
        public string? UrlEcmDonwload { get; set; }
        public string? NomeArquivo { get; set; }
    }
}
