class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method

     public int RemainingMinutesInOven(int min){
        return 40 - min;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

     public int PreparationTimeInMinutes(int camada){
        return camada * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int n, int m ){
        return (n * 2) + m;
    }
}
