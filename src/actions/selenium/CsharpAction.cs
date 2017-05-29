using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace actions.selenium{
    class CsharpAction{
        
        

        
        public void run(Dictionary<string, object> Params){
          
          
           IWebDriver driver;
            driver = new ChromeDriver("C:\\Program Files\\RedwoodHQ\\public\\automationscripts\\Sample\\admin\\bin"); 
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

    }
}