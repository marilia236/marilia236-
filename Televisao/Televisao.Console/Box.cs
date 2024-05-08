using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao.Console
{
    public class Box
    {
        #region Atributos

        private int _canal;

        private int _volume;

        private string _mensagem;

        private int _numeroCanais;

        private bool _estado;


        #endregion


        #region Propriedades

        //Propriedade de leitura e escrita porque eu quero monstrar e também alterar
        public int Canal
        {
            get
            { 
                return _canal; 
            }

            set 
            {
                if (value >= 0 && value <= _numeroCanais)
                {
                    _canal = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return _volume;

            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }
        }


        //Propriedade só de leitura
        public string Mensagem
        {
            get 
            { 
                return _mensagem;
            }
           /* set 
            { 
                _mensagem = value;
            } */
        }

        public bool Estado
        {
            get
            { 
                return _estado;
            }

        }

        #endregion

        #region Métodos

        //Construtor dos métodos (por defeito)
        public Box() 
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso!!";
            _numeroCanais = 10;
        }

        //Construtor por paramentros
        public Box(int numeroCanais)
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso!!";
            _numeroCanais = numeroCanais;
        }


        public void Ligar()
        {
            _estado=true;
            try
            {
                LerInfo();
            }
            catch (Exception e) 
            {
                _mensagem = e.Message;
            }

            _mensagem = "Box ligada com sucesso!!";
        }

        public void Desligar()
        {
            _estado=false;

            try
            {
                //coloco o código que quero executar
                //e que se correr mal a culpa é externa
                GravarInfo();
            }
            catch(Exception e) //esta é generica dá pra todas
            {
                _mensagem= e.Message;   
            }

            _mensagem= "Box desligada!!!";
        }

        private void GravarInfo()
        {
            string ficheiro = @"tvInfo.txt";

            //8;40 (canal 8, volume 40)
            string linha = $"{_canal};{_volume}";

            //False- Abre o ficheiro e limpa/apaga o que lá tá
            //Permite aceder o ficheiro- streamWriter
            StreamWriter sw = new StreamWriter(ficheiro, false);

            //Criara um ficheiro se ele não existir
            if(!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            sw.WriteLine(linha);
            sw.Close();
        }

        private void LerInfo()
        {
            string ficheiro = @"tvInfo.txt";

            //faz a ligação pra ler lá
            StreamReader sr;

            //Criara um ficheiro se ele não existir
            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    Canal = Convert.ToInt32(campos[0]);
                    Volume = Convert.ToInt32(campos[1]);
                }

                sr.Close();
            }

            
        }


        #endregion 
    }
}
