
using System.Text;
using static Tests.Utility;
namespace ConsoleApp1;


internal class CarReport
{
    IEnumerable<Car> _cars;

    public CarReport(IEnumerable<Car> cars) => _cars = cars;

    public string Print()
    {
        var builder = new StringBuilder();
        var sumMph  = 0.0;

        foreach (var car in _cars)
        {
            var mph = GetMph(car.Distance, car.Hours);
            sumMph += mph;

            builder.AppendLine($"{car.Name}: {mph} MPH");
        }

        var avgMph = sumMph / _cars.Count();
        builder.AppendLine($"-------------------------");
        builder.AppendLine($"Avg Speed: {avgMph} MPH");

        return builder.ToString();
    }
}
