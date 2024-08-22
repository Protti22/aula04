double totalPedido = 0;
bool pedidoAberto = true;

while (pedidoAberto)
{
    Console.WriteLine("Bem vindo ao mehor sistema de gerenciamento de pedidos do ads");
    Console.WriteLine("1 - Adicionar item ao pedido");
    Console.WriteLine("2 - Exbir total do pedido");
    Console.WriteLine("3 - Finalizar pedido e sair");
    Console.WriteLine("Escolha uma dessas opções");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
        Console.WriteLine ("Escolha um item abaixo;");
        Console.WriteLine (" 1 - pizza R$30,00");
        Console.WriteLine (" 2 - hamburguer R$15,00");
        Console.WriteLine (" 3 - refrigerante R$5,00");
        string escolha = Console.ReadLine ();
        if(escolha == "1")
        {
            totalPedido = totalPedido + 30.00;
            Console.WriteLine("pizza adicionado ao pedido");

        }
        else if(escolha == "2")
        {
            totalPedido = totalPedido += 15.00;
            Console.WriteLine("hamburguer adicionado ao pedido");
        }

        else if(escolha == "3")
        {
            totalPedido = totalPedido += 5.00;
            Console.WriteLine("Refrigerante adicionado ao pedido");
        }

        else
        {
            Console.WriteLine("Opção invalida");
        }


        break;

        case "2":
        Console.WriteLine ($"O total do pedido é: {totalPedido}");
        break;

        case "3":
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine ("digite novamente:");
        break;

}
}
