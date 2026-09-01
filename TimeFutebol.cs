public class TimeFutebol
{
    private string _nomeOficial = "";
    private string _nomeConhecido = "";
    private string _apelidoDaTorcida = "";

    public TimeFutebol(
        string nomeOficial,
        string nomeConhecido,
        string apelidoDaTorcida)
    {
        this.NomeOficial = nomeOficial;
        this.NomeConhecido = nomeConhecido;
        this.ApelidoDaTorcida = apelidoDaTorcida;
    }

    public string NomeOficial
    {
        get
        {
            return _nomeOficial;
        }

        set
        {
            _nomeOficial = value;
        }
    }

    public string NomeConhecido
    {
        get
        {
            return _nomeConhecido;
        }

        set
        {
            _nomeConhecido = value;
        }
    }

    public string ApelidoDaTorcida
    {
        get
        {
            return _apelidoDaTorcida;
        }

        set
        {
            _apelidoDaTorcida = value;
        }
    }
}