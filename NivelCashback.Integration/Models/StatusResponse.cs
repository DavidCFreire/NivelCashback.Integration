using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelCashback.Integration.Models
{
    public class StatusResponse
    {
        public bool ServerOnline { get; set; }
        public bool TokenValido { get; set; }
        public bool Sucesso { get; set; }
    }
}
