using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace PageObjects;

public class ToursPage : Page
{
    public ToursPage(IWebDriver webDriver) : base(webDriver,
        "https://intercity.by/tours/country/egypt/?q=departureCities%3D448%26Destination%3D9%26TourDate%255B0%255D%3D22.02.2022%26Durations%255B0%255D%3D5%26Durations%255B1%255D%3D8%26Durations%255B2%255D%3D12%26Durations%255B3%255D%3D15%26Durations%255B4%255D%3D19%26Durations%255B5%255D%3D22%26AdultCount%3D2#tab_tour") { }

    public IWebElement ToursList => FindElementBy(By.CssSelector("#tab_tour > div > div > div.catalog__list.flc.catalog__list--full > div > div > div"));

    public ReadOnlyCollection<IWebElement> Tours => ToursList.FindElements(By.TagName("div"));

    public override ToursPage OpenPage()
    {
        WebDriver.Navigate().GoToUrl(EntryUrl);
        return this;
    }
}