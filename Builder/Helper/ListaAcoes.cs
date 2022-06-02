using Builder.Controller;
using Builder.Repository;
using Builder.Repository.Interface;
using System.Collections.Generic;

namespace Builder.Helper
{
    public class ListaAcoes
    {
        public IList<IExecAfterNF> RetornarListaAcoes()
        {
            NotaFiscalDAO o1 = new NotaFiscalDAO();
            EnviarEmail o2 = new EnviarEmail();
            EnviarSMS o3 = new EnviarSMS();
            Multiplicador o4 = new Multiplicador(2.5);
            IList<IExecAfterNF> listaAcoes = new List<IExecAfterNF>();
            listaAcoes.Add(o1);
            listaAcoes.Add(o2);
            listaAcoes.Add(o3);
            listaAcoes.Add(o4);
            return listaAcoes;
        }
    }
}
