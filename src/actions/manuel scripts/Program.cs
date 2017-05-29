using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

/// <summary>
/// VISUAL STUDIO ÜZERİNDEN REDWOODHQ'YA KOD COMMIT ETMEK
/// </summary>

namespace testqa_repo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver;
            driver = new ChromeDriver("C:/Program Files/RedwoodHQ/public/automationscripts/Sample/admin/bin"); 
            driver.Navigate().GoToUrl("https://www.optiim.com");
        }
    }
}
