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
    class Test
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.optiim.com";
        }
    }
}
