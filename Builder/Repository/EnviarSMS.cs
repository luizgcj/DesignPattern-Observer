using Builder.Entity;
using Builder.Repository.Interface;
using System;

namespace Builder.Repository
{
    public class EnviarSMS : IExecAfterNF
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("sms");
        }
    }
}
