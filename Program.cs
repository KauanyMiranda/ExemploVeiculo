using System.Numerics;
using static System.Console;
using static System.Convert;
public class Program
{
    static void Main(string[] args)
    {
        VeiculoDAO vdao = new VeiculoDAO();

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
                

                Clear();
                WriteLine("+++++ CADASTRO +++++\n");
                Write("Informe a Placa: ");
                string placa = ReadLine();
                Write("Informe o Número do motor: ");
                string nmotor = ReadLine();

                Veiculo v = new Veiculo(placa, nmotor);

                Write("Informe o NIV: ");
                v.niv = ReadLine();
                Write("Informe o Renavam: ");
                v.renavam = ReadLine();
                Write("Informe o Modelo: ");
                v.modelo = ReadLine();
                Write("Informe a Marca: ");
                v.marca = ReadLine();


                vdao.Cadastrar(v);

                WriteLine("Cadastrado com sucesso!");
            }
            else if(op == 2)
            {
                List<Veiculo> veiculos = vdao.ListarTodos();

                Clear();
                WriteLine("+++++ VEÍCULOS +++++\n");
                foreach (var v in veiculos)
                {
                    WriteLine($"Placa: {v.placa}");
                    WriteLine($"Número do Motor: {v.nMotor}");
                    WriteLine($"NIV: {v.niv}");
                    WriteLine($"Renavam: {v.renavam}");
                    WriteLine($"Modelo: {v.modelo}");
                    WriteLine($"Marca: {v.modelo}\n");
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
                WriteLine($"NIV: {placa.niv}");
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
