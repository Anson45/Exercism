class Lasagna
{

    public int ExpectedMinutesInOven()=> 40;
    
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

}
