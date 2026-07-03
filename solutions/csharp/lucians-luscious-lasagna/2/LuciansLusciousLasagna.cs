class Lasagna
{

    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    
    public int RemainingMinutesInOven(int ovenTime)
    {
        return 40 - ovenTime;
    }
    public int PreparationTimeInMinutes(int layer)
    {
        return layer*2;
    }
    public int ElapsedTimeInMinutes(int layer,int ovenTime)
    {
        return  (layer*2)+ovenTime;;
    }


    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
