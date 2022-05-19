using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageOblectSolution1
{
    class PageProvider
    {
        DriverProvider driverProvider;

        public void Quit()
        {
            driverProvider.Quit();
        }

        public IWebDriver SetDriver()
        {
            if (driverProvider == null)
            {
                driverProvider = new DriverProvider();
            }
            return driverProvider.GetDriver();
        }

        public T InitPage<T>()
        {
            object[] param = { SetDriver() };
            return (T)Activator.CreateInstance(typeof(T), param);
        }
    }
}
