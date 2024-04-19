namespace Atividades
{
     class PontoApp {
        
        public static void Run() {
        // Exemplo de uso da classe Ponto
        Ponto ponto1 = new(); // Construtor padrão
        Ponto ponto2 = new(3, 4); // Construtor que define as coordenadas diretamente
        Ponto ponto3 = new(10, 6); // Construtor que define as coordenadas diretamente

       
        Console.WriteLine("");
        Console.WriteLine($"Coordenadas do ponto 1: ({ponto1.X}, {ponto1.Y})");
        Console.WriteLine($"Coordenadas do ponto 2: ({ponto2.X}, {ponto2.Y})");

        Console.WriteLine("Distância entre ponto 1 e ponto 2: {0}", ponto1.Distancia(ponto2));
        Console.WriteLine("Distância entre ponto 1 e ponto 3: {0}", ponto1.Distancia(ponto3));

        ponto1.Movimentar(2, 2);
        Console.WriteLine($"Coordenadas do ponto 1 após movimento: ({ponto1.X}, {ponto1.Y})");
       }

    }
}