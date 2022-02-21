using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using WebDriver;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

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

    public bool IsContactsFieldOpened()
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