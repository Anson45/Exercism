class Lasagna
{
    private int MinutesInOven = 40;

    public int ExpectedMinutesInOven()
    {
        return MinutesInOven;
    }
    
    public int RemainingMinutesInOven(int ovenTime)
    {
        return MinutesInOven - ovenTime;
    }
    public int PreparationTimeInMinutes(int layer)
    {
        return layer*2;
    }
    public int ElapsedTimeInMinutes(int layer,int ovenTime)
    {
        var value = (layer*2)+ovenTime;
        return value;
    }


    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
