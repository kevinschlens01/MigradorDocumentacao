using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Fornecedor
    {
        public string? Id { get; set; }
        public string? IdPessoa { get; set; }
        public string? IdConta { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NumeroDocumentoJuridico { get; set; }
        public string? NomeTipoLogra { get; set; }
        public string? NomeLogradouro { get; set; }
        public string? NumeroLogradouro { get; set; }
        public string? NomeBairro { get; set; }
        public string? NomeLocalidade { get; set; }
        public string? ComplementoLogradouro { get; set; }
        public string? CepEndereco { get; set; }
        public string? PontoReferenciaLogradouro { get; set; }
        public string? SiglaEstado { get; set; }
        public string? NomePais { get; set; }
        public string? Contatos { get; set; }
        public string? IdSituacao { get; set; }
        public string? NomeSituacao { get; set; }
        public string? AtivoInativo { get; set; }
        public string? id_cliente { get; set; }
        public string? portal_id { get; set; }
        public string? transparencia_hash_cliente { get; set; }
        public string? hash_registro { get; set; }
    }
}
