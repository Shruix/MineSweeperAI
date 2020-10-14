using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperAI.Scripts {
    class Test {
        
        public static void TestFunction() {
            ChromeOptions options = new ChromeOptions();

            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("http://minesweeperonline.com/");
        }
    }

    
}
