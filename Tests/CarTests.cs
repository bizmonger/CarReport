namespace Tests;

[TestFixture]
public class Tests
{

    [Test]
    public void Get_MPH()
    {
        // Setup
        var distance = 10;
        var hours    = 1;

        // Test
        var mph = Utility.GetMph(distance, hours);

        // Verify
        Assert.IsTrue(mph == 10);
    }
}