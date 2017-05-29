using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace actions.selenium{
    class CsharpAction{
        public void run(Dictionary<string, object> Params){
            
           // IWebDriver driver = new ChromeDriver();
            
             IWebDriver driver = new ChromeDriver("C:\\Program Files\\RedwoodHQ\\public\\automationscripts\\ProjeAdı\\admin\\bin");
            driver.Url = "http://www.demoqa.com";
        }
    }
}