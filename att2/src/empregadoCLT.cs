namespace ATT2
{
    class EmpregadoCLT(string _nome, string _cpf, string _endereco, double _salarioBruto) : Empregado(_nome, _cpf, _endereco)
    {
        private double sBrutoCLT = _salarioBruto;
        public double SBrutoCLT {
            get { return sBrutoCLT; }
            set { sBrutoCLT = value;}
        }

        private double sLiqCLT;
        public double SLiqCLT {
            get { return sLiqCLT; }
            set { sLiqCLT = value;}
        }
        

        public double SalarioCLT() {
            if(SBrutoCLT <= 5000) return SLiqCLT = .8 * SBrutoCLT; 
            SLiqCLT =  .725 * SBrutoCLT;
            return SLiqCLT;
        }


        public new void ExibirDadosEmpregados() {
            base.ExibirDadosEmpregados();
            Console.WriteLine(SBrutoCLT);
            Console.WriteLine(SalarioCLT());
        }
    }
}