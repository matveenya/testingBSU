using NUnit.Framework;
using Services;

namespace lab10;

public class Tests
{
    private WebDriverManager _manager;
        
    [SetUp]
    public void Setup()
    {
        _manager = new WebDriverManager();
    }


    [Test]
    public void SearchTripsTest()
    {
        var url = _manager.PassTripFeatures();
        Assert.AreEqual("https://intercity.by/tours/country/egypt/?q=departureCities%3D38%26Destination%3D9%26TourDate%255B0%255D%3D05.04.2022%26Durations%255B0%255D%3D11%26Durations%255B1%255D%3D22%26AdultCount%3D2#tab_tour"
            , url);
    }

    [Test]
    public void OpenContactsFieldTest()
    {
        var result = _manager.IsContactsFieldOpened();
        Assert.IsTrue(result);
    }

    [Test]
    public void ShowTourInfoFieldTest()
    {
        var result = _manager.IsTourInfoFieldOpened();
        Assert.IsTrue(result);
    }

    [Test]
    public void ToursCountTest()
    {
        var result = _manager.FindToursCount();
        Assert.AreEqual(result, 1254);
    }
}