using OpenQA.Selenium;

namespace PageObjects;

public class HomePage : Page
{
    public HomePage(IWebDriver webDriver) : base(webDriver, "https://intercity.by/") { }
        
    public IWebElement FromPlaceField => FindElementBy(By.XPath("/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[1]/button"));
    public IWebElement ToPlaceField => FindElementBy(By.XPath("/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[2]/button"));
    public IWebElement FindButton => FindElementBy(By.CssSelector("body > div.root > div > nav > div > div > div.main-nav__cell.main-nav__cell--search.js-v-scope > form > div > div.product-search__cell-form > div > div > div.ps-form__cell.ps-form__cell--submit > button"));
    public IWebElement FromBrestButton => FindElementBy(By.XPath("/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]"));
    public IWebElement ToTurkeyRadio => FindElementBy(By.XPath(
        "/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div[2]/div/div[3]/label/input"));
    public IWebElement CloseToButton => FindElementBy(By.XPath(
        "/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[2]/div/div/div[2]/div/div[1]/button"));
    public IWebElement DateField => FindElementBy(By.XPath("/html/body/div[4]/div/nav/div/div/div[2]/form/div/div[1]/div/div/div[6]/button"));
    public IWebElement ContactsButton =>
        FindElementBy(By.XPath("/html/body/div[4]/div/header/div/div/div[3]/div[1]/div/div[1]/div/div[3]/span"));
    public IWebElement ContactsField =>
        FindElementBy(By.XPath("/html/body/div[4]/div/header/div/div/div[3]/div[2]/div[2]/div[2]"));

    public HomePage EnterFromPlace()
    {
        FromPlaceField.Click();
        FromBrestButton.Click();
        return this;
    }

    public HomePage EnterToPlace()
    {
        ToTurkeyRadio.Click();
        return this;
    }

    public HomePage SelectDate(string date)
    {
        DateField.SendKeys(date);
        return this;
    }

    public HomePage CloseToField()
    {
        CloseToButton.Click();
        return this;
    }
    
    public HomePage SearchTrips()
    {
        FindButton.Click();
        ImplicitlyWait();
        return this;
    }

    public HomePage OpenContactsField()
    {
        ContactsButton.Click();
        return this;
    }

    public override HomePage OpenPage()
    {
        WebDriver.Navigate().GoToUrl(EntryUrl);
        return this;
    }
}