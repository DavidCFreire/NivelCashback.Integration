using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelCashback.Integration.Models
{
    public class BonificacaoResponse
    {
        public bool SolicitarEmail { get; set; }
        public bool BonificacaoRealizada { get; set; }
        public bool Sucesso { get; set; }
        public string MsgErro { get; set; }
        public int? CodErro { get; set; }
    }
}
