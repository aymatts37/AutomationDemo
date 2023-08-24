using AutomationDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo.Hooks
{
    public class BasePage
    {
        public IWebDriver driver;

        [SetUp]
        public void start()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Environments.AutoUrl);

        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
        }

    }
        
















    
}
