namespace ConsoleApp1;

public class Car
{
    public Car(string name, int distance, int hours)
    {
        Name     = name;
        Distance = distance;
        Hours    = hours;
    }

    public string Name { get; set; }
    public int Distance { get; set; }
    public int Hours { get; set; }
}