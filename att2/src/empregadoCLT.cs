namespace ATT2
{
    class EmpregadoCLT() : Empregado
    {
        private double SBrutoClt {get; set;} = 0.0;
        private double SLiqCLT {get; set;} = 0.0;

        public double SalarioCLT() {
            if(SBrutoClt <= 5000) return SLiqCLT = .8 * SBrutoClt; 
            SLiqCLT =  .725 * SBrutoClt;
            return SLiqCLT;
        }


        public new void ExibirDados() {
            base.ExibirDados();
            Console.WriteLine(SBrutoClt);
            Console.WriteLine(SalarioCLT());
        }

        public new void InserirDados() 
        {
            base.InserirDados();

            SBrutoClt = Util.ReadValue<double>("informe o salário bruto: ");
            SLiqCLT = SalarioCLT();
        }

    }
}