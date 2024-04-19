namespace Atividades
{

    class TimeApp
    {
        public static void Run()
        {

            Console.WriteLine("Digite as horas: ");
            int hora1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os minutos: ");
            int min1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os segundos: ");
            int seg1 = Convert.ToInt32(Console.ReadLine());

            Tempo tempo1 = new Tempo(hora1, min1, seg1);

            int escolha = 0;
            while (escolha < 4)
            {
                Console.WriteLine("\nPara somar dois horarios digite 1." +
                "\nPara subtrair dois horarios digite 2." +
                "\nPara saber a hora informada digite 3." +
                "\nPara sair digite 4.");
                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("\nDigite as horas para o calculo: ");
                    int hora2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite os minutos para o calculo: ");
                    int min2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite os segundos para o calculo: ");
                    int seg2 = Convert.ToInt32(Console.ReadLine());

                    Tempo tempo2 = new Tempo(hora2, min2, seg2);
                    Console.WriteLine("A soma dos dois horarios é: " + tempo1.SomaHoras(tempo2).ToString(@"hh\:mm\:ss"));
                }

                if (escolha == 2)
                {
                    Console.WriteLine("\nDigite as horas para o calculo: ");
                    int hora2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite os minutos para o calculo: ");
                    int min2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite os segundos para o calculo: ");
                    int seg2 = Convert.ToInt32(Console.ReadLine());

                    Tempo tempo2 = new Tempo(hora2, min2, seg2);
                    Console.WriteLine("A subtração dos dois horarios é: " + tempo1.SubtraiHoras(tempo2).ToString(@"hh\:mm\:ss"));
                }
                if (escolha == 3)
                {
                    Tempo tempo3 = new Tempo();
                    Console.WriteLine($"O horario digitado é: {tempo3.HoraMinSeg(tempo1)}");
                }
            }


        }
    }
}
