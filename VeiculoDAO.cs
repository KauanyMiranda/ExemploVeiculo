
public class VeiculoDAO
{
    public List<Veiculo> listaVeiculos = new List<Veiculo> ();

    public void Cadastrar(Veiculo v)
    {
        listaVeiculos.Add(v);
    }

    public List<Veiculo> ListarTodos()
    {
        return listaVeiculos;
    }

    public void Excluir(string placa)
    {
        Veiculo vExcluir = listaVeiculos.First(p => p.placa == placa);
        listaVeiculos.Remove(vExcluir);
    }

    public Veiculo Buscar(string vplaca)
    {
        Veiculo vBuscar = listaVeiculos.First(p => p.placa == vplaca);

        return vBuscar;
      
    }
}
