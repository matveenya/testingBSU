using OpenQA.Selenium;

namespace PageObjects;

public class GeorgiaPage : Page
{
    public GeorgiaPage(IWebDriver webDriver) : base(webDriver, "https://intercity.by/tours/country/georgia/") { }

    public IWebElement HideTourInfoButton =>
        FindElementBy(By.XPath("/html/body/div[4]/div/div[4]/main/section/div[2]/div/div[1]/div[2]/button"));

    public IWebElement TourInfoField => FindElementBy(By.XPath("/html/body/div[4]/div/div[4]/main/section/div[2]/div/div[2]/div/div[1]/div[1]/div/div/div/div[2]/div"));

    public GeorgiaPage ShowTourInfo()
    {
        HideTourInfoButton.Click();
        ImplicitlyWait();
        return this;
    }
    
    public override GeorgiaPage OpenPage()
    {
        WebDriver.Navigate().GoToUrl(EntryUrl);
        return this;
    }
}