using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace PageObjects;

public class Page
{
    public Page(IWebDriver webDriver, string entryUrl)
    {
        WebDriver = webDriver;
        EntryUrl = entryUrl;
        PageFactory.InitElements(webDriver, this);
    }

    protected IWebDriver WebDriver { get; }

    protected string EntryUrl { get; }

    public string CurrentUrl => WebDriver.Url;

    public virtual Page OpenPage()
    {
        WebDriver.Navigate().GoToUrl(EntryUrl);

        return this;
    }

    protected IWebElement FindElementBy(By key)
    {
        return new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20)).Until(driver => driver.FindElement(key));
    }

    protected IReadOnlyCollection<IWebElement> FindElementsBy(By key)
    {
        return new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20)).Until(driver => driver.FindElements(key));
    }

    protected void WaitForPageToLoad()
    {
        var webDriverWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30))
            .Until(ExpectedConditions.UrlToBe("https://intercity.by/tours/country/egypt/?q=departureCities%3D38%26Destination%3D9%26TourDate%255B0%255D%3D05.04.2022%26Durations%255B0%255D%3D11%26Durations%255B1%255D%3D22%26AdultCount%3D2#tab_tour"));
    }
}