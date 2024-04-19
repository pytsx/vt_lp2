namespace ATT2 {


    class EmpregadoHorista(string _nome, string _cpf, string _endereco, int _nHora, double _precoH) : Empregado (_cpf, _nome, _endereco) {

        private int nHora = _nHora;
        public int NHora {
            get { return nHora;}
            set { nHora = value; }
        }


        private double precoH = _precoH;
        public double PrecoH {
            get { return precoH;}
            set { precoH = value; }
        }


        private double salLiqH;
        public double SalLiqH {
            get { return salLiqH;}
            set { salLiqH = value;}
        }


        public double SalarioH() {
            return NHora  * precoH * .85;
        }

         public new void ExibirDadosEmpregados() {
            base.ExibirDadosEmpregados();
            Console.WriteLine(NHora);
            Console.WriteLine(SalLiqH);
            Console.WriteLine(SalarioH());
        }
    }
}