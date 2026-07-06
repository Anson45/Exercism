class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsPerDay = new int[] { 0, 2, 5, 3, 7, 8, 4};
        return birdsPerDay;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int value = 0;
        for(int i = 0; i < numberOfDays; i++ ){
            value = value + birdsPerDay[i]; 
        }
        return value;
    }

    public int BusyDays()
    {
        int busy = 0;

        foreach (int count in birdsPerDay)
        {
            if (count >= 5)
            {
                busy++;
            }
        }
    
        return busy;
        
    }
}
