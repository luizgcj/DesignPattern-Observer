using Builder.Entity;
using Builder.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class NotaFiscalBuilder
    {
        public int Numero { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataHoraEmissao { get; private set; }
        public IList<Item> todosItens = new List<Item>();
        private double valorTotal;
        private double impostos;
        private IList<IExecAfterNF> executarAcoes = new List<IExecAfterNF>();

        public NotaFiscalBuilder(IList<IExecAfterNF> listaAcoes)
        {
            this.executarAcoes = listaAcoes;
        }

        public NotaFiscalBuilder SetNumero(int Numero)
        {
            this.Numero = Numero;
            return this;
        }

        public NotaFiscalBuilder SetRazaoSocial(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
            return this;
        }

        public NotaFiscalBuilder SetCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
            return this;
        }

        public NotaFiscalBuilder SetDataHoraEmissao()
        {
            this.DataHoraEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder SetItem(Item item)
        {
            this.todosItens.Add(item);
            valorTotal += item.ValorUnitario;
            impostos += item.ValorUnitario * 0.05;
            return this;
        }

        public NotaFiscal CriarNota()
        {
            NotaFiscal nf = new NotaFiscal(this.Numero, this.RazaoSocial, this.Cnpj, this.DataHoraEmissao, this.todosItens, this.valorTotal, this.impostos);

            foreach(IExecAfterNF acoes in executarAcoes)
            {
                acoes.Executar(nf);
            }

            return nf;
        }

        public void AdicionarAcoes(IExecAfterNF novaAcao)
        {
            this.executarAcoes.Add(novaAcao);
        }
    }
}
