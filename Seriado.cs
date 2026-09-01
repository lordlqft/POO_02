public class Seriado
{
    private string _nome;
    private int _temporadas;
    private int _faixaEtaria;
    private string _genero;

    public Seriado(string nome, int temporadas, int faixaEtaria, string genero)
    {
        _nome = nome;
        _temporadas = temporadas;
        _faixaEtaria = faixaEtaria;
        _genero = genero;
    }

    public string Nome { get { return _nome; } set { _nome = value; } }

    public int Temporadas { get { return _temporadas; } set { _temporadas = value; } }

    public int FaixaEtaria { get { return _faixaEtaria; } set { _faixaEtaria = value; } }

    public string Genero { get { return _genero; } set { _genero = value; } }
}