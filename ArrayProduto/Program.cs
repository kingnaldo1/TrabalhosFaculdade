using ArrayProduto;

Produto[] vetProduto = new Produto[5];

for (int i = 0; i <vetProduto.Length; i++)
{

    Console.WriteLine($"Cadastro do Produto {i + 1}:");
        vetProduto[i] = new Produto();
    Console.Write("Cadastre o código do produto: ");
    vetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o nome do Produto: ");
    vetProduto[i].nome = Console.ReadLine();
    Console.Write("Cadastre o preço do produto: ");
    vetProduto[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Cadastre a quantidade do produto: ");
    vetProduto[i].quantidade = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i <vetProduto.Length; i++)
    vetProduto[i].MostrarAtributos();

foreach (Produto c in vetProduto)
    c.MostrarAtributos();

foreach (Produto c in vetProduto)
    c.VerificarEstoqueMinimo();

foreach (Produto c in vetProduto)
        {
            if (c.VerificarEstoqueMinimo())
            {
                Console.WriteLine($"O produto {c.nome} está abaixo do estoque mínimo.");
            }
        }

        // Aplicar reajuste de 5% aos produtos com preço > 500
        foreach (Produto c in vetProduto)
            c.AplicarReajuste();


        // Apresente novamente os produtos após o reajuste
        Console.WriteLine("\nProdutos após o reajuste de preço: ");
        foreach (Produto c in vetProduto)
        {
            c.MostrarAtributos();
            Console.WriteLine();
        }

        // Realizar saída de estoque
        Console.Write("\nDigite o código do produto para realizar a saída de estoque: ");
        int codigoSaida = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de saída: ");
        int quantidadeSaida = int.Parse(Console.ReadLine());

        foreach (Produto c in vetProduto)
        {
            if (c.codigo == codigoSaida)
            {
                c.RealizarSaidaEstoque(quantidadeSaida);
                break;
            }
        }

        // Apresente novamente os produtos após a saída de estoque
        Console.WriteLine("\nProdutos após a saída de estoque:");
        foreach (Produto c in vetProduto)
        {
            c.MostrarAtributos();
            Console.WriteLine();
        }


