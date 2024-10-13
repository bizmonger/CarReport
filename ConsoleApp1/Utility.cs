using ConsoleApp1;
namespace Tests;
public static class Utility
{
    public static float GetMph(int distance, int hours) => distance / hours;

    public static string Report(IEnumerable<Car> cars)
    {
        var report = new CarReport(cars);
        return report.Print();
    }
}