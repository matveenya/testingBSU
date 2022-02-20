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
            // .EnterToPlace()
            // .CloseToField()
            .SearchTrips();

        return homePage.CurrentUrl;
    }

    public void DestroyDrive()
    {
        ChromeDriverEntity.CloseDriver();
    }
}