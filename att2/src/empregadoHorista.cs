namespace ATT2
{


    class EmpregadoHorista() : Empregado
    {
        private int NHora { get; set; } = 0;
        private int PrecoH { get; set; } = 0;
        private double SalLiqH { get; set; } = 0.0;

        public double SalarioH()
        {
            return NHora * PrecoH * .85;
        }

        public new void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine(NHora);
            Console.WriteLine(SalLiqH);
            Console.WriteLine(SalarioH());
        }

        public new void InserirDados() 
        {
            base.InserirDados();

            NHora = Util.ReadValue<int>("informe o numero de horas: ");
            PrecoH = Util.ReadValue<int>("informe o preço por hora: ");
            SalLiqH = SalarioH();
        }
    }
}