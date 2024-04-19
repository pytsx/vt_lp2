namespace Atividades
{
        
     class VetorApp
        {
            public static void Run()
            {
                Vetor v1 = new(true);
                Vetor v2 = new(10, 20);
                Vetor v3 = v2.Soma(v1) ;

                Console.WriteLine($"vetor 1 x {v1.x} y {v1.y}");
                Console.WriteLine($"vetor 2 x {v2.x} y {v2.y}");
                Console.WriteLine($"vetor 3 x {v3.x} y {v3.y}");
            }
        }
}
