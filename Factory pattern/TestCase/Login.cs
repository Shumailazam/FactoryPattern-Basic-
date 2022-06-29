using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_pattern.WrapperFactory;
using OpenQA.Selenium;

namespace Factory_pattern.TestCase
{
    internal class Login
    {
        public void test()
        {
            BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication("https://google.com");

            

           

            BrowserFactory.CloseAllDrivers();
        }
    }
}
