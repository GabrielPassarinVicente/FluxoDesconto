using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoDesconto
{
    public class CompraCliente
    {

        double desconto;
        double totalCompra;
        double compraValorTotal;
        double faltaValor;
        double valorCompra;
        bool achou = false;
        public CompraCliente()
        {

            Console.WriteLine("Fluxo Desconto com cliente");
            Console.Write("Valor da compra:");
            valorCompra = double.Parse(Console.ReadLine());
            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.BuscaClientes();
            
            
            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.CPF == cpf);

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].CPF == cpf)
                {
                    achou = true;

                    if (clientes[i].BeneficiadoDoMes == false)
                    {
                        desconto = valorCompra * 0.15;
                        totalCompra = valorCompra - desconto;
                        Console.WriteLine("Valor total:" + valorCompra);
                        Console.WriteLine("Valor do desconto:" + desconto);
                        Console.WriteLine("Valor do total com desconto:" + totalCompra);
                        clientes[i].BeneficiadoDoMes = true;

                        break;

                    }
                    else
                    {
                         Console.WriteLine("Cliente já utilizou o desconto este mês");
                        desconto = valorCompra * 0.10;
                        totalCompra = valorCompra - desconto;
                        Console.WriteLine("Valor total:" + valorCompra);
                        Console.WriteLine("Valor do desconto:" + desconto);
                        Console.WriteLine("Valor do total com desconto:" + totalCompra);
                        break;

                    }
                        
          
                   
                }
                else
                {
                    continue;
                }
                
            }
              
            if(achou == false)
            {

                if (valorCompra >= 150)
                {
                    desconto = valorCompra * 0.10;
                    totalCompra = valorCompra - desconto;
                    Console.WriteLine("Desconto:");
                    Console.WriteLine("Valor total:" + valorCompra);
                    Console.WriteLine("Valor do desconto:" + desconto);
                    Console.WriteLine("Valor do total com desconto:" + totalCompra);
                }
                else
                {
                    Console.Write("Deseja adicionar mais um item?");
                    string adicionarItem = Console.ReadLine();
                    if (adicionarItem == "Sim")
                    {
                        faltaValor = 150 - valorCompra;
                        Console.WriteLine("Valor que falta: " + faltaValor);
                        totalCompra = faltaValor + valorCompra;
                        desconto = totalCompra * 0.10;
                        compraValorTotal = totalCompra - desconto;
                        Console.WriteLine("Valor com item:" + totalCompra);
                        Console.WriteLine("valor do desconto:" + desconto);
                        Console.WriteLine("valor do total com desconto:" + compraValorTotal);


                    }
                    else
                    {
                        Console.WriteLine("Valor total:" + valorCompra);
                    }

                }
            }


        }


    }


}
