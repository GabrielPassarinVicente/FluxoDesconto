using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoDesconto
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public bool BeneficiadoDoMes { get; set; } = false;

        public string CPF { get; set; } = string.Empty ;

        public List<Cliente> BuscaClientes()
        {
            return new List<Cliente>
            {
                new Cliente { Nome = "Nome", BeneficiadoDoMes = true, CPF = "123.456.789-00" },
                new Cliente { Nome = "Nome", BeneficiadoDoMes = false, CPF = "123.456.888-00" },
                new Cliente { Nome = "Nome", BeneficiadoDoMes = true, CPF = "123.456.755-00" },
                new Cliente { Nome = "Nome", BeneficiadoDoMes = false, CPF = "123.456.999-00" },
               
            };
        }


    }
}
