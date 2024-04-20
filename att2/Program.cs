namespace ATT2
{
    class Program
    {
        Empregado[] _Empregados = new Empregado[10];
        int Index = 0;


        public static void Main(string[] args)
        {
            Program app = new();

            string? opt = CreateDialog("Bem-vindo(a) ao Menu de Contabilidade e Recursos Humanos \n");

            while (opt != null && opt != "4")
            {
                switch (opt)
                {
                    case "1":
                        if (app.Index <= 10)
                        {
                            app.InserirCLT();
                            app.Index++;
                            opt = CreateDialog();
                        }
                        else opt = CreateDialog("número máximo de funcionários atingido \n");
                        break;
                    case "2":
                        if (app.Index <= 10)
                        {
                            app.InserirHorista();
                            app.Index++;
                            opt = CreateDialog();
                        }
                        else opt = CreateDialog("número máximo de funcionários atingido \n");
                        break;
                    case "3":
                        app.Imprimir();
                        opt = CreateDialog();
                        break;
                    default:
                        opt = CreateDialog("opção inválida \n");
                        break;
                }
            }
        }

        private static string? CreateDialog(string? message = "")
        {
            Util.CreateMenu([
                message ?? "\n",
                "[1] Cadastrar Empregado CLT",
                "[2] Cadastrar Empregado Horista",
                "[3] Imprimir Relatório de Empregados",
                "[4] Sair"
            ]);
            return Util.ReadValue<string>("\ninforme um valor: ");
        }


        private void InserirCLT()
        {
            Console.WriteLine("Cadastrando empregado CLT");
            EmpregadoCLT clt = new();
            clt.InserirDados();
            _Empregados[Index] = clt;
        }

        private void InserirHorista()
        {
            Console.WriteLine("Cadastrando empregado Horista");
            EmpregadoHorista horista = new();
            horista.InserirDados();
            _Empregados[Index] = horista;
        }


        private void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório");

            Console.Write("\ntotal empregados: ");
            Console.WriteLine(Index);
            for (int i = 0; i < Index; i++)
            {
                
                Console.WriteLine("");
                if (_Empregados[i].GetType() == typeof(EmpregadoHorista))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ((EmpregadoHorista)_Empregados[i]).ExibirDados();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    ((EmpregadoCLT)_Empregados[i]).ExibirDados();
                }
                Console.ResetColor();
            }
        }
    }
}