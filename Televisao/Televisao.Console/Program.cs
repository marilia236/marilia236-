namespace Televisao.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar o objecto meo do tipo Box(classe)
            Box meo = new Box();

            //Box nos = new Box();
            //o meo passa a ter a mesma referência do nos
            //meo = nos;

            if(meo == null)
            {
                System.Console.WriteLine("A box ainda não foi criada!!");
            }
            else
            {
                System.Console.WriteLine("A box já foi criada!!");

                int op;
                do
                {
                    do
                    {
                        //System.Console.Clear();
                        System.Console.WriteLine("********COMANDO DA BOX********");
                        System.Console.WriteLine("1-Ligar a Box");
                        System.Console.WriteLine("2-Desligar a Box");
                        System.Console.WriteLine("0-Sair");
                        System.Console.WriteLine("Escolha op:");
                    } while (!int.TryParse(System.Console.ReadLine(), out op));
                } while (op < 0 || op > 2);

                meo.Ligar();

                switch (op)
                {
                    case 1:

                        if(meo.Estado == false)
                        {
                            meo.Ligar();
                            //ir buscar a mensagem da box
                            System.Console.WriteLine(meo.Mensagem); 
                        }
                        else
                        {
                            System.Console.WriteLine("Box já está ligada");
                        }

                        //Como a Mensagem é uma propriedade só de leitura não posso fazer o código embaixo
                        //meo.Mensagem = "Olá";
                        break;

                    case 2:
                        meo.Desligar();
                        System.Console.WriteLine(meo.Mensagem);
                        break;
                }
            }

            //meo= new Box();

           
        }
    }
}
