
namespace Atividades
{
        
    internal class Vetor
    {
        //...que contenha dois atributos, representando as coordenadas de um vetor
        public double x;
        public double y;

        //...o primeiro (default) que crie o vetor nulo
        public Vetor()
        {
            x = 0;
            y = 0;
        }

        //...o segundo (de aridade 2) que fornece os valores das coordenadas
        public Vetor(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        //...o terceiro que receba os valores x e y do usuário, pelo teclado
        public Vetor(bool askUser)
        {
            if(askUser){
                Console.Write("informe o x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("informe o y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
        }

        //...um método que retorna o produto escalar entre dois vetores
        //é calculado multiplicando as coordenadas correspondentes dos vetores e somando os resultados
        //mas o resultado é um número escalar, não um vetor.
        public double ProdutoEscalar(Vetor vetor2)
        {
            double position1 = x * vetor2.x;
            double position2 = y * vetor2.y;

            double resultadoVetorial = position1 + position2;

            return resultadoVetorial;
        }

        //...um método que soma dois vetores, retornando o vetor soma como resultado
        public Vetor Soma(Vetor vetor2)
        {
            double position1 = x + vetor2.x;
            double position2 = y + vetor2.y;

            Vetor vetorR = new Vetor(position1, position2);

            //Vetor vetorR = new Vetor(x + vetor2.X, y + vetor2.Y);

            return vetorR;
        }
    }

}
