using Builder.Entity;
using Builder.Repository.Interface;
using System;

namespace Builder.Controller
{
    public class NotaFiscalDAO : IExecAfterNF
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Salvar no banco");
        }
    }
}
