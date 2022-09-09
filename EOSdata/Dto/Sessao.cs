using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOSdata.Dto
{
    public class Sessao
    {
        public int CodigoSessao { get; set; }
        public string Cliente { get; set; }
        public DateTime DataSessao { get; set; }
        public string Local { get; set; }
        public int QtdFotos { get; set; }
    }
}
