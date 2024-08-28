using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.GMP
{
    public class Veiculos
    {
        public string? PortalId { get; set; }
        public string? TransparenciaHashCliente { get; set; }
        public string? HashRegistro { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? CodigoFilial { get; set; }
        public string? NomeFilial { get; set; }
        public string? CnpjFilial { get; set; }
        public string? TipoVeiculo { get; set; }
        public string? NomeTipoVeiculo { get; set; }
        public string? CodigoVeiculo { get; set; }
        public string? PrefixoVeiculo { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }
        public string? TcmVeiculo { get; set; }
        public int? CodigoTipo { get; set; }
        public string? NomeTipo { get; set; }
        public string? CodigoGrupo { get; set; }
        public string? NomeGrupo { get; set; }
        public string? CodigoClasse { get; set; }
        public string? NomeClasse { get; set; }
        public string? CodigoMarca { get; set; }
        public int? NomeMarca { get; set; }
        public string? CodigoModelo { get; set; }
        public string? NomeModelo { get; set; }
        public string? CodigoCategoria { get; set; }
        public string? NomeCategoria { get; set; }
        public string? CnhCategoria { get; set; }
        public string? Carroceria { get; set; }
        public int? AnoFabric { get; set; }
        public int? AnoModelo { get; set; }
        public string? Chassi { get; set; }
        public string? Renavan { get; set; }
        public string? Potencia { get; set; }
        public string? Cilindrada { get; set; }
        public string? Liquido { get; set; }
        public string? Lotacao { get; set; }
        public string? Portas { get; set; }
        public string? NomeMarcador { get; set; }
        public string? SiglaMarcador { get; set; }
        public string? TipoMarcador { get; set; }
        public int? CmbCodigoProduto { get; set; }
        public string? CmbNomeProduto { get; set; }
        public string? Situacao { get; set; }
        public string? NomeSituacao { get; set; }
        public DateTime? DataSituacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataDesativacao { get; set; }
        public string? CodigoBem { get; set; }
        public string? Especificacao { get; set; }
        public string? Descricao { get; set; }
        public string? EmpenhoNumero { get; set; }
        public DateTime? DataAquisicao { get; set; }
        public decimal? VlrAtual { get; set; }
        public string? AtlCodigoLocal { get; set; }
        public string? AtlNomeLocal { get; set; }
        public string? AtlSiglaLocal { get; set; }
        public string? CodigoGResponsavel { get; set; }
        public string? NomeGResponsavel { get; set; }
        public string? AtlCodigoSecretaria { get; set; }
        public string? AtlNomeSecretaria { get; set; }
        public string? AtlSecCodigoGResponsavel { get; set; }
        public string? AtlSecNomeGResponsavel { get; set; }
        public string? CodigoUnidadeOrcamentaria { get; set; }
        public string? Alienado { get; set; }
        public DateTime? DataAlienacao { get; set; }
        public string? CodigoGAlienacao { get; set; }
        public string? NomeGAlienado { get; set; }
        public string? Agregado { get; set; }
        public string? ContratoAgregacao { get; set; }
        public DateTime? DataAgregacao { get; set; }
        public DateTime? DataDesagregamento { get; set; }
        public string? CodigoGAgregado { get; set; }
        public string? NomeGAgregado { get; set; }
        public string? Observacao { get; set; }
        public string? nomeOrigemVeiculo { get; set; }
        public string? NomeAtivoInativoMotivo { get; set; }
    }
}
