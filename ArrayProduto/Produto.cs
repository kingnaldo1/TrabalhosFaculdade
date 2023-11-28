using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto 
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int quantidade;


        public bool VerificarEstoqueMinimo()
    {
        return quantidade <= 3;
    }

    public void AplicarReajuste()
    {
        if (preco > 500)
        {
            preco *= 1.05; // Aumento de 5%
        }
    }

    public void RealizarSaidaEstoque(int quantidadeSaida)
    {
        if (quantidadeSaida <= quantidade)
        {
            quantidade -= quantidadeSaida;
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }



        public void MostrarAtributos(){
            Console.WriteLine("Código: " + codigo + "\tNome: "
            + nome + "\tPreço: " + preco + "\tQuantidade: " + quantidade);
        }

    }


}
    
