using Builder.Entity;
using Builder.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Repository
{
    public class Multiplicador : IExecAfterNF
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine($"Valor da nota multiplicado pelo fator {this.Fator} = {nf.ValorTotal * this.Fator}");
        }
    }
}
