using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace actions.selenium{
    class CsharpAction{
        
        

        
        public void run(Dictionary<string, object> Params){
          
          
          // IWebDriver driver;
            //driver = new FirefoxDriver("C:\\Program Files\\RedwoodHQ\\public\\automationscripts\\Sample\\admin\\bin"); 
           // driver.Navigate().GoToUrl("https://www.amazon.com");
              IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
        }

    }
}