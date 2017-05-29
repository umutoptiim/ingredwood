using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;



namespace actions.selenium{
    class CsharpAction{
        
        

        
        public void run(Dictionary<string, object> Params){
          
          
           IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

    }
}