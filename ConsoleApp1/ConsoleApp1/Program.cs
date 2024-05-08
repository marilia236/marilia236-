namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    

        //Instanciar o objeto (são objetos)
        Carro carrinho = new Carro();

        Console.WriteLine(carrinho.Estado);

        Carro popo = new Carro();
        //Ler o valor que está no atributo
        Console.WriteLine(popo.Estado);
        
        //Escrever o valor dentro do atributo
        //NESTE CASO VAI DAR ERRO PORQUE A PROPRIEDADE É SÓ DE LEITURA
        //popo.Estado = "Olá, consegui entrar no carro";

        Console.WriteLine(popo.Estado);

        Carro boguinhas = new Carro("Ferrari", "California", "Amarelo");
        Console.WriteLine(boguinhas.Estado);

        string marca, modelo, cor;

        Console.Write("Escolha a marca:");
        marca = Console.ReadLine();

        Console.Write("Escolha o modelo:");
        modelo = Console.ReadLine();

        Console.Write("Escolha a cor:");
        cor = Console.ReadLine();

        Carro meuCarro = new Carro(marca, modelo, cor);
        Console.WriteLine(meuCarro.Estado);

        //Esta linha vai ddar erro porque o atributo _modelo é privado(e devem ser sempre privados)
        //meuCarro._modelo="Ferrari";


    }

}
