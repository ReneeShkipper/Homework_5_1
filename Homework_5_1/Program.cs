class program
{ 
    static float Average(float a, float b)
    {   
 
        return (a + b) / 2;
    }

    static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine( Average(a, b));
    }
}