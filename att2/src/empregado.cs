namespace ATT2
{
    class Empregado(string _nome, string _cpf, string _endereco)
    {
        private string nome = _nome;
        public string Nome { 
            get { return nome; }
            set { nome = value; }
         }

        private string cpf = _cpf;
        public string Cpf {
            get { return cpf; }
            set { cpf = value; }
        }

        private string endereco = _endereco;
        public string Endereco {
            get { return endereco; }
            set { endereco = value; }
        }


        public void ExibirDadosEmpregados() {
            Console.WriteLine(Nome);
            Console.WriteLine(Cpf);
            Console.WriteLine(Endereco);
        }

        
    }
}