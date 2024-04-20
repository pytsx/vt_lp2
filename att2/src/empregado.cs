namespace ATT2
{
    internal class Empregado()
    {
        private string Nome  { get; set; } = "";
        private string Cpf  { get; set; }= "";
        private string Endereco { get; set; }= "";


        public void ExibirDados() {
            Console.WriteLine($"{Nome}");
            Console.WriteLine($"{Cpf}");
            Console.WriteLine($"{Endereco}");
        }


        public void InserirDados() {
            Nome = Util.ReadValue<string>("informe o nome: ") ?? Nome;
            Cpf = Util.ReadValue<string>("informe o CPF: ") ?? Cpf;
            Endereco = Util.ReadValue<string>("informe o Endereco: ") ?? Endereco;
        }
    }
}