using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.CPE
{
    public class Transferencia
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string? HashRegistro { get; set; }
        public string HashCliente { get; set; }
        public string? NomEmpresa { get; set; }
        public string? NroEmpresaCnpj { get; set; }
        public string? NomFilial { get; set; }
        public string? NroFilialCnpj { get; set; }
        public int? AnoConvenio { get; set; }
        public string? NrdConvenio { get; set; }
        public string? NomConvenio { get; set; }
        public DateTime? DatConvenio { get; set; }
        public string? MesConvenio { get; set; }
        public int? AnoProcesso { get; set; }
        public string? NrdProcesso { get; set; }
        public string? SblPessoaParticipanteTipo { get; set; }
        public string? NomPessoaParticipanteTipo { get; set; }
        public string? NomPessoaParticipante { get; set; }
        public string? NroPessoaParticipanteCpfCnpj { get; set; }
        public string? HstConvenio { get; set; }
        public decimal? VlrConvenio { get; set; }
        public string? Anexo { get; set; }
        public string? HashRegistroCpe { get; set; }
        public string? ControleCpe { get; set; }
        public string? SblTipoConvenio { get; set; }
    }
}
