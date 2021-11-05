using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelCashback.Integration.Models
{
    public class BonificacaoRequest
    {
        public string token { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Valor { get; set; }
        public string CodControle { get; set; }
        public bool CadastrarSemEmail { get; set; }
        public bool Pagamento { get; set; }
        public string CodigoPagamento { get; set; }
    }
}
