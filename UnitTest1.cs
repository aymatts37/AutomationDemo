using AutomationDemo.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationDemo
{
    public class Tests //: BasePage
    {
        string email(int rand) => $"Odunayo2z{rand}@yahoo.com";
        Random randomGenerator = new Random();
        int randomInt;

        [Test]
        public void SignUp()
        {

            BasePage basePage = new BasePage();

            basePage.start();


            var signup = basePage.driver.FindElement(By.CssSelector("*[class='fa fa-lock']"));
            signup.Click();

            var name = basePage.driver.FindElement(By.XPath("//input[@type='text']"));
            name.SendKeys("Odunayo");

            randomInt = randomGenerator.Next(1, 1000);
            //var email = basePage.driver.FindElement(By.XPath("//*[@data-qa='signup-email']"));
            //email.SendKeys("Odunayo2z@yahoo.com");
            basePage.driver.FindElement(By.XPath("//*[@data-qa='signup-email']")).SendKeys(email(randomInt));

            Thread.Sleep(3000);

            var createBttn = basePage.driver.FindElement(By.XPath("//*[@data-qa='signup-button']"));
            createBttn.Click();

            //Thread.Sleep(4000);

            var title = basePage.driver.FindElement(By.XPath("(//input[@type='radio'])[1]"));
            title.Click();
            //Thread.Sleep(2000);
            var pasword = basePage.driver.FindElement(By.XPath("//*[@type='password']"));
            pasword.SendKeys("Abey");

            var dayofBirth = basePage.driver.FindElement(By.XPath("//*[@data-qa='days']"));
            SelectElement element = new SelectElement(dayofBirth);
            //element.SelectByValue("4");
            element.SelectByIndex(1);

            var monthofBirth = basePage.driver.FindElement(By.XPath("//*[@data-qa='months']"));
            SelectElement element1 = new SelectElement(monthofBirth);
            //element1.SelectByText("March");
            element1.SelectByIndex(1);

            var yearofBirth = basePage.driver.FindElement(By.XPath("//*[@data-qa='years']"));
            SelectElement element2 = new SelectElement(yearofBirth);
            //element2.SelectByValue("2021");
            element2.SelectByIndex(1);


            var fullName = basePage.driver.FindElement(By.XPath("(//*[@class='form-control'])[7]"));

            fullName.SendKeys("Odunayo");

            var lastName = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"last_name\"])"));
            lastName.SendKeys("Bogunjoko");

            var companyName = basePage.driver.FindElement(By.XPath("(//*[@type='text'])[5]"));

            companyName.SendKeys("Tranter");

            var addressName = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"address\"])"));
            addressName.SendKeys("12 Vespasian Road");

            var addressName2 = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"address2\"])"));
            addressName2.SendKeys("13 Hill Road");

            var countryName = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"country\"])"));
            SelectElement element3 = new SelectElement(countryName);
            element3.SelectByText("United States");

            var stateName = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"state\"])"));
            stateName.SendKeys("Lagos");

            var cityName = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"city\"])"));
            cityName.SendKeys("Badagry");

            var zipcode = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"zipcode\"])"));

            zipcode.SendKeys("SO22");

            var mobilenumber = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"mobile_number\"])"));

            mobilenumber.SendKeys("08068451476");


            var createaccount = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"create-account\"])"));
            createaccount.Click();


            basePage.stop();
        }

        [Test]
        public void Login()
        {

            BasePage basePage = new BasePage();

            basePage.start();

            var login = basePage.driver.FindElement(By.CssSelector("*[class='fa fa-lock']"));
            login.Click();

            var emailAddress = basePage.driver.FindElement(By.XPath("//input[@data-qa='login-email']"));
            emailAddress.SendKeys("Odunayo2z@yahoo.com");

            var pasword = basePage.driver.FindElement(By.XPath("(//*[@type=\"password\"])"));
            pasword.SendKeys("Abey");

            var loginBttn = basePage.driver.FindElement(By.XPath("(//*[@data-qa=\"login-button\"])"));
            loginBttn.Click();

            basePage.stop();
        }


    }
    
}






   