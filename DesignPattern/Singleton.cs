class Singleton
{
    private Singleton()
    {

    }
    public static Singleton instance = null ;
    public static int count =0;
    public static Singleton GetSingleton
    {
        if (instance ==null)
        {
            count = count +1;
            instance = new Singleton();
        }
        return instance 
    }
    public void PrintInstances(){
        Console.WriteLine( " The count is {0}", count);
    }
}