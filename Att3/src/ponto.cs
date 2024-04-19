namespace Atividades
{
    class Ponto
{
    // Atributos
    // → implemente aqui
    public double X { get; set; }
    public double Y { get; set; }

    // Construtor padrão
    // → implemente aqui
    public Ponto() {
        X = 0.0;
        Y = 0.0;
    }

    public Ponto(double _x, double _y){
        X = _x;
        Y = _y;
    }

    // Construtor que permite definir as coordenadas x e y diretamente no código-fonte
    // (pode ser gerado automaticamente)
    // → implemente aqui

    //getters and setters (podem ser gerados automaticamente)
    // → implemente aqui

    // Método para calcular a distância entre dois pontos
    public double Distancia(Ponto outroPonto)
    {
        double distancia = Math.Sqrt(Math.Pow((outroPonto.X - X), 2) + Math.Pow((outroPonto.Y - Y), 2));
        return distancia;
    }

    // Método para movimentar o ponto
    // → implemente aqui
    public void Movimentar(double deltaX, double deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

}

}