using MarsQA.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver = new ChromeDriver(@"Document:/MarsQA");
        [AfterScenario]
          public void CleanUp()
        {
            driver.Dispose();
        }

    }
}
