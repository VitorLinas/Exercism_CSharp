class Lasagna
{
    // Tempo que a lasanha deve ficar no forno

    public int ExpectedMinutesInOven() => 40;

    // Recebe o tempo que a lasanha está no forno e retorna quanto falta

     public int RemainingMinutesInOven(int min){
        return 40 - min;
    }

    // Tempo de demora tendo em vista o número de camadas (2 min cada)

     public int PreparationTimeInMinutes(int camada){
        return camada * 2;
    }

    // Soma do tempo sendo n as camadas e m os tempo que a lasanha está no forno

    public int ElapsedTimeInMinutes(int n, int m ){
        return (n * 2) + m;
    }
}
