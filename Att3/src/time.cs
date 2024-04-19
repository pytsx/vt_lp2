namespace Atividades
{
    internal class Tempo
    {
        private int hora;
        private int min;
        private int seg;

        // getters and setters: 
        public int Hora { get => hora; set => hora = value; }
        public int Min { get => min; set => min = value; }
        public int Seg { get => seg; set => seg = value; }

        public Tempo()
        {
            Hora = 0;
            Min = 0;
            Seg = 0;
        }

        public Tempo(int _hora, int _min, int _segs)
        {
            Hora = _hora;
            Min = _min;
            Seg = _segs;
        }

        public string HoraMinSeg(Tempo tempo)
        {
            return $"{tempo.Hora}:{tempo.Min}:{tempo.Seg}";
        }

        public TimeSpan SomaHoras(Tempo tempo)
        {
            //Primeiro, ele calcula o total de horas multiplicando a soma das horas
            //(Hora + tempo.Hora) por 3600 (o número de segundos em uma hora).
            double horaT = (Hora + tempo.Hora) * 3600;
            //Em seguida, calcula o total de minutos multiplicando a soma
            //dos minutos por 60(o número de segundos em um minuto).
            double minT = (Min + tempo.Min) * 60;
            double segsT = Seg + tempo.Seg;

            //Os valores calculados são convertidos em segundos e passados para
            //o construtor de TimeSpan, que cria e retorna um novo objeto
            //TimeSpan representando o tempo total.
            return TimeSpan.FromSeconds(horaT + minT + segsT);
        }

        public TimeSpan SubtraiHoras(Tempo tempo)
        {
            //Calcula a diferença em h, m e s usando Math.Abs()
            //para garantir que a diferença seja sempre positiva.
            double horaT = Math.Abs(Hora - tempo.Hora) * 3600;
            double minT = Math.Abs(Min - tempo.Min) * 60;
            double segsT = Math.Abs(Seg - tempo.Seg);

            return TimeSpan.FromSeconds(horaT + minT + segsT);
        }
    }

}