using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class CaseStudy2
    {
        [TestMethod]
        public void TestMethod1()
        {
            ;
            string linkText1 = "Calculators & Resources", linkText2 = "Calculators", linkText3 = "Budget Calculator";
            
            IWebDriver myD;
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Selenium Jars", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //myD = new FirefoxDriver(service);
            myD = new ChromeDriver("C:\\Selenium Jars");
            myD.Url = "http://www.youcandealwithit.com/";
            myD.Manage().Window.Maximize();
            myD.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(3);

            //Thread.Sleep(2000);
            Actions act = new Actions(myD);
            act.MoveToElement(myD.FindElement(By.XPath("//a[text()='Borrowers']"))).Build().Perform();
            myD.FindElement(By.LinkText(linkText1)).Click();
            titleCheck(linkText1, myD.Title);
            //Thread.Sleep(2000);
            myD.FindElement(By.LinkText(linkText2)).Click();
            titleCheck(linkText2, myD.Title);
            //Thread.Sleep(2000);
            myD.FindElement(By.LinkText(linkText3)).Click();
            titleCheck(linkText3, myD.Title);
            //Thread.Sleep(2000);

            myD.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[1]/input")).SendKeys("230");
            myD.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/input")).SendKeys("130");
            myD.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[3]/input")).SendKeys("330");
            myD.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[4]/div[1]/input")).SendKeys("8000");
            myD.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[4]/div[2]/input")).SendKeys("730");

            System.Console.WriteLine("Under/Over Budget is: " + myD.FindElement(By.Id("underOverBudget")).GetAttribute("value"));
           
            double monthlyExpense = double.Parse(myD.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value"));
            double monthlyPay = double.Parse(myD.FindElement(By.Id("totalMonthlyIncome")).GetAttribute("value"));


            if (monthlyExpense < monthlyPay )
            {
                Console.WriteLine("You are Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are VM");
            }

            myD.Close();
        }
        public void titleCheck(string s1, string s2)
        {
            if (s2.Contains(s1))
            {
                Console.WriteLine("Pass for" + s1 );
            }
            else
            {
                Console.WriteLine("Fail for " + s1);
            }
        }
    }
}
