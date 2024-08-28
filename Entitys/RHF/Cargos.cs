using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorDocumentacao.Entitys.RHF
{
    public class Cargos
    {
        public string? Id { get; set; }
        public string? CompetenciaId { get; set; }
        public string? PortalId { get; set; }
        public string? ClienteId { get; set; }
        public decimal? RemuneracaoBase { get; set; }
        public string? NomeCargo { get; set; }
        public string? Lei { get; set; }
        public int? NumeroVagasDisponiveis { get; set; }
        public int? NumeroVagasOcupadas { get; set; }
        public int? NumeroVagasTotal { get; set; }
    }
}
