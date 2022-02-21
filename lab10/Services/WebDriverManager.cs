using OpenQA.Selenium;
using PageObjects;
using WebDriver;

namespace Services;

public class WebDriverManager
{
    private IWebDriver _webDriver;

    public WebDriverManager()
    {
        _webDriver = ChromeDriverEntity.Driver;
    }

    public string PassTripFeatures()
    {
        var homePage = new HomePage(_webDriver).OpenPage();

        homePage.EnterFromPlace()
            .SearchTrips();

        return homePage.CurrentUrl;
    }

    public bool IsMessageFieldOpened()
    {
        var homePage = new HomePage(_webDriver).OpenPage();

        return homePage.OpenContactsField().ContactsField.Displayed;
    }

    public bool IsTourInfoFieldOpened()
    {
        var georgiaPage = new GeorgiaPage(_webDriver).OpenPage();
        
        return georgiaPage.ShowTourInfo().TourInfoField.Displayed;
    }

    public int FindToursCount()
    {
        var toursPage = new ToursPage(_webDriver).OpenPage();

        return toursPage.Tours.Count;
    }

    public void DestroyDrive()
    {
        ChromeDriverEntity.CloseDriver();
    }
}