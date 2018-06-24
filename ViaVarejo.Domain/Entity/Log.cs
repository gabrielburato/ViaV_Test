using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ViaVarejo.Domain.Entity
{
    [Table("CalculoHistoricoLog")]
    public class Log
    {
        public int Id_Historico { get; set; }

        public string Calculo { get; set; }

        public string Resultado { get; set; }
    }
}
