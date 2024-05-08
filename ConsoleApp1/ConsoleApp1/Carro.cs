namespace ConsoleApp1;

public class Carro
{
    #region Atributos

    //Atributos
    string _marca;

    string _modelo;

    string _cor;

    int _velocidade;

    int _VelocidadeMaxima;

    bool _ligado;

    string _estado;

    #endregion

    #region Propriedades

    public string Estado
    {
        get { return _estado; }

    }

    public bool Ligado 
    {
        get { return _ligado; }
    }

    public int Velocidade 
    {
        get { return _velocidade; } 

        set
        { 
            if (value >= 0 && value <= _VelocidadeMaxima)
            _velocidade = value;
        }
    }

    public int VelocidadeMaxima
    {
        get { return _VelocidadeMaxima; }

        set { _VelocidadeMaxima = value; }
    }

    #endregion


    #region Métodos

    //Método epecial chamado de construtor
    //Construtor por default(defeito)
    public Carro()
    {
        _marca = "Renault";
        _modelo = "Captur";
        _cor = "Vermelho";
        _velocidade = 0;
        _VelocidadeMaxima = 20;
        _ligado = false;
        //Concatenação de strings colocar sempre o $ no inicio
        _estado = $"Foi criado um {_marca} {_modelo}, {_cor} com sucesso!";
    }

    //Construtor por parametros
    public Carro(string marca, string modelo, string cor)
    {
        _marca = marca;
        _modelo = modelo;
        _cor = cor;
        _velocidade = 0;
        _VelocidadeMaxima = 20;
        _ligado = false;
        _estado = $"Foi criado um {_marca} {_modelo}, {_cor} com sucesso!";
    }

    public void Ligar()
    {
        _ligado=true;
        _estado = "Bruumm Bruumm";
    }
    
    public void Desligar() 
    {
        _ligado = false;
        _estado = "Puf";
    }

}

    #endregion


