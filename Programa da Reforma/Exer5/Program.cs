namespace Exer5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int anoAtual, num, anoNasc, anoIng, idade,anosTrab;
            string resp;
            Console.WriteLine("Digite o ano atual(éinteiro: ");
            if (anoAtual > 0 && anoAtual > 0)
            {
                Console.WriteLine("Digite o número(é numero) do funcionário:");
                if (num == num && num > 0)
                { }
            }
            else
            {
                Console.WriteLine("Digite o ano de nascimento:");
                if (((anoNasc > 0) && anoAtual - anoNasc <= 65) && (anoAtual - anoNasc >= 18))
                { }
                else {
                    Console.WriteLine("Digite o ano de ingresso:");
                    if ((anoNasc > 0) && anoIng - anoNasc >= 18)
                    {

                    }
                    {
                        idade = anoAtual - anoNasc;
                        anosTrab = anoAtual - anoIng;
                        Console.WriteLine("Digite o funcionário com o nº" + num + " com " + idade + " anos e" + anosTrab + " anos trabalhados");
                        if (idade >= 65 || anosTrab >= 30 || (idade >= 60 && anosTrab >= 25))
                        {
                            Console.WriteLine("Tem direito a Reforma");
                        }
                        else
                        {
                            Console.WriteLine("Não tem direito a Reforma");
                        }

                    }
                    Console.WriteLine("Pretende continuar no programa(s/n)?");
                    if ((resp é string) && resp== "s" || resp == "S" || resp == "n" || resp == "N")
                    {
                        if (resp == "n" || resp == "N")
                        { }


                    }

                }
            }
        }
    }
}
