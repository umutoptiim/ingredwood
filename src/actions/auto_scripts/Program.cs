using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace actions.selenium{
    class CsharpBrowser{
        public void run(Dictionary<string, object> Params){
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }
    }
}