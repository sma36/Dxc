using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class CaseStudy1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            String searchString = "DXC Technologies";
            
            myD = new ChromeDriver("C:\\Selenium Jars");
            myD.Url = "https://www.google.com/";
            myD.FindElement(By.Name("q")).SendKeys(searchString);
            Thread.Sleep(2000);
            myD.FindElement(By.Name("btnK")).Click();
            String title = myD.Title;
            Console.WriteLine(title);
           
            Console.WriteLine(myD.FindElement(By.Id("resultStats")).Text);

            if (title.Contains(searchString))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            myD.Close();           

        }
    }
}
