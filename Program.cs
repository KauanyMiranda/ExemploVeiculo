using System.Numerics;
using static System.Console;
using static System.Convert;
public class Program
{
    static void Main(string[] args)
    {
        VeiculoDAO vdao = new VeiculoDAO();
        Veiculo v = new Veiculo();
        Veiculo v1 = new Veiculo(); // Criando um novo objeto

        //v1.niv = "0561561"; // atribuindo valores
        v1.placa = "QBE-8324"; // atribuindo valores
        v1.modelo = "Saveiro G6"; // atribuindo valores

        do
        {
            Clear();
            WriteLine("+++++ CADASTRO DE VEÍCULOS +++++\n");
            WriteLine("[1] Cadastrar");
            WriteLine("[2] Listar Veículos ");
            WriteLine("[3] Remover ");
            WriteLine("[4] Buscar ");
            int op = ToInt32(ReadLine());

            if (op == 1)
            {
                try
                {
                    Clear();
                    WriteLine("+++++ CADASTRO +++++\n");
                    Write("Informe a Placa: ");
                    v.placa = ReadLine();
                    Write("Informe o Número do motor: ");
                    v.nMotor = ReadLine();
                    Write("Informe o NIV: ");
                    string n = ReadLine();
                    v.SetNiv(n);
                    Write("Informe o Renavam: ");
                    v.renavam = ReadLine();
                    Write("Informe o Modelo: ");
                    v.modelo = ReadLine();
                    Write("Informe a Marca: ");
                    v.marca = ReadLine();


                    vdao.Cadastrar(v);

                    WriteLine("Cadastrado com sucesso!");
                }catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }


            }
            else if(op == 2)
            {
                List<Veiculo> veiculos = vdao.ListarTodos();

                Clear();
                WriteLine("+++++ VEÍCULOS +++++\n");
                foreach (var ve in veiculos)
                {
                    WriteLine($"Placa: {ve.placa}");
                    WriteLine($"Número do Motor: {ve.nMotor}");
                    WriteLine($"NIV: {ve.GetNiv()}");
                    WriteLine($"Renavam: {ve.renavam}");
                    WriteLine($"Modelo: {ve.modelo}");
                    WriteLine($"Marca: {ve.modelo}\n");
                }

                ReadKey();
            }
            else if(op == 3)
            {
                Clear();
                WriteLine("+++++ EXCLUSÃO DE VEÍCULOS +++++\n");
                Write("Informe a placa: ");
                string placa = ReadLine();

                vdao.Excluir(placa);

                WriteLine("Excluído com sucesso!");

                ReadKey();
            }
            else if(op == 4)
            {
                Clear();
                WriteLine("+++++ BUSCAR +++++\n");
                Write("Informe a placa: ");
                string vplaca = ReadLine();
              
                Veiculo placa = vdao.Buscar(vplaca);

                WriteLine($"\nPlaca: {placa.placa}");
                WriteLine($"Número do Motor: {placa.nMotor}");
                WriteLine($"NIV: {placa.GetNiv()}");
                WriteLine($"Renavam: {placa.renavam}");
                WriteLine($"Modelo: {placa.modelo}");
                WriteLine($"Marca: {placa.modelo}");


                ReadKey();
            }
            else
            {
                break;
            }


        }
        while (true);
        

    }
}
