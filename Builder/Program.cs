using Builder.Builder;
using Builder.Controller;
using Builder.Entity;
using Builder.Helper;
using Builder.Repository;
using Builder.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            

            NotaFiscalBuilder notaFiscalTemp = new NotaFiscalBuilder(new ListaAcoes().RetornarListaAcoes()); 

            notaFiscalTemp
                .SetNumero(1255)
                .SetRazaoSocial("Luiz Gonzaga da Costa Junior")
                .SetCnpj("016.004.186-43")
                .SetDataHoraEmissao()
                .SetItem(new ItemNotaFiscalBuilder()
                             .SetCodigo(1)
                             .SetDescricao("Produto 1")
                             .SetValorUnitario(100.0)
                             .CriarItemNotaFiscal())
                .SetItem(new ItemNotaFiscalBuilder()
                             .SetCodigo(2)
                             .SetDescricao("Produto 2")
                             .SetValorUnitario(200.0)
                             .CriarItemNotaFiscal());
            

            NotaFiscal notaFiscal = notaFiscalTemp.CriarNota();
            Console.WriteLine(notaFiscal.ToString());



        }
        
    }
}
