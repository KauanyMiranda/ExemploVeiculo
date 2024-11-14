
public class Veiculo
{
    public string placa;
    public string nMotor;
    private string niv;
    public string renavam;
    public string modelo;
    public string marca;


    public void SetNiv(string n)
    {
        if (niv.Length == 17)
        {
            niv = n;
        }
        else
        {
            throw new Exception("NIV inválido");
        }
    }

    public string GetNiv()
    {
        return niv;
    }

}
