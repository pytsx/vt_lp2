namespace ATT2
{
    class Program {
        private static EmpregadoCLT[] _EmpregadosCLT = [];
        private static EmpregadoHorista[] _EmpregadosHorista = [];
        

        private static int _index = 0;
        private static int Index {
            get { return _index; }
            set { _index = value; }
        }

        public static void Main(string[] args) {
            Console.WriteLine("Bem-vindo(a) ao Menu de Contabilidade e Recursos Humanos");
            Console.WriteLine("=========================================================");
            ShowMenu();
            string? opt = Console.ReadLine();
            while (opt != null && opt != "4") {
                if(opt == "1"){
                    if(Index <= 10) {
                        Index++;
                        InserirCLT();
                        ShowMenu();
                        opt = Console.ReadLine();
                    } else {
                        Console.WriteLine("número máximo de funcionários atingido");
                        ShowMenu();
                        opt = Console.ReadLine();
                    }
                } else if(opt == "2") {
                    if(Index <= 10){

                    Index++;
                    InserirHorista();
                    ShowMenu();
                    opt = Console.ReadLine();
                    } else {
                        Console.WriteLine("número máximo de funcionários atingido");
                        ShowMenu();
                        opt = Console.ReadLine();
                    }
                } else if(opt == "3") {
                    Imprimir();
                    ShowMenu();
                    opt = Console.ReadLine();
                } else {
                    Console.WriteLine("opção inválida");
                    ShowMenu();
                    opt = Console.ReadLine();
                }
            }

            
        }   

        public static void ShowMenu() {
            Util.CreateMenu([
                "[1] Cadastrar Empregado CLT",
                "[2] Cadastrar Empregado Horista",
                "[3] Imprimir Relatório de Empregados",
                "[4] Sair"
            ]);
        }


        public static void InserirCLT() {
            Console.WriteLine("Cadastrando empregado CLT");
            Util.CreateForm(["nome", "cpf", "endereço", "salarioBruto"], (formdata) => {
                string nome = formdata.Values["nome"];
                string cpf = formdata.Values["cpf"];
                string endereco = formdata.Values["endereço"];
                double salarioBruto = Convert.ToDouble(formdata.Values["salarioBruto"]);

                Array.Resize(ref _EmpregadosCLT, _EmpregadosCLT.Length + 1);

                _EmpregadosCLT[_EmpregadosCLT.Length - 1] = new EmpregadoCLT(nome, cpf, endereco, salarioBruto);
            });
        }

        public static void InserirHorista() {
            Console.WriteLine("Cadastrando empregado Horista");
            Util.CreateForm(["nome", "cpf", "endereço", "nHora", "precoH"], (formdata) => {
                string nome = formdata.Values["nome"];
                string cpf = formdata.Values["cpf"];
                string endereco = formdata.Values["endereço"];
                int nHora = Convert.ToInt32(formdata.Values["nHora"]);
                double precoH = Convert.ToDouble(formdata.Values["precoH"]);
                Array.Resize(ref _EmpregadosHorista, _EmpregadosHorista.Length + 1);
                _EmpregadosHorista[_EmpregadosHorista.Length - 1] = new EmpregadoHorista(nome, cpf, endereco, nHora, precoH);
            
            });
        }


        public static void Imprimir() {
            Console.WriteLine("Imprimindo relatório");

            Console.WriteLine("");
            Console.WriteLine("Empregados CLT");
            foreach (EmpregadoCLT empregado in _EmpregadosCLT) 
            {
                empregado.ExibirDadosEmpregados();
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Empregados CLT");
            foreach (EmpregadoHorista empregado in _EmpregadosHorista) 
            {
                empregado.ExibirDadosEmpregados();
                Console.WriteLine("");
            }
        }
    } 
}