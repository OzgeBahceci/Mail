using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace mail
{
    class Program
    {
        static void Main(string[] args)
        {
         
                //Firefox
                IWebDriver driver = new FirefoxDriver();
                string link = @"https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1541450988&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3dae2360a1-de81-8248-0a53-b6b8280e171b&id=292841&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015";
                driver.Navigate().GoToUrl(link);

                //Oturum Acma
                driver.FindElement(By.XPath("//*[@id='i0116']")).SendKeys("*****");
                driver.FindElement(By.XPath("//*[@id='idSIButton9']")).Click();
                System.Threading.Thread.Sleep(5000);

                driver.FindElement(By.XPath("//*[@id='i0118']")).SendKeys("***");
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("inline-block")).Click();
                Console.WriteLine("****** hesabi ile oturum acildi");
                System.Threading.Thread.Sleep(25000);



                //Gelen Kutusu

                driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[2]/div/div/div[1]")).Click();//arama ikonu
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_3_Dj_hTouuB2dHKedXLI4e")).Click();//tüm klasörler
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div/div/div[1]/div/div/div/div[2]/button")).Click();//gelen kutusunda ara
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_1hYiUDwiTL9FO03jyclFJD")).Click();//arama çubuğuna tıkla
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_1hYiUDwiTL9FO03jyclFJD")).SendKeys("****");
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[2]/div/div[2]/i")).Click();//arama
                System.Threading.Thread.Sleep(5000);





                driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[1]/div[1]/div/div[1]")).Click();//hepsini secme
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[1]/div/div/div/div/div[1]/div[2]/button")).Click();//arsivle
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("**** adli kisinin mailleri arsivlendi");


                //Gelen Kutusu

                driver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div[2]/div/div[1]/div[1]/i")).Click();

                driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[2]/div/div/div[1]")).Click();//arama ikonu
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_3_Dj_hTouuB2dHKedXLI4e")).Click();//tüm klasörler
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div/div/div[1]/div/div/div/div[2]/button")).Click();//gelen kutusunda ara
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_1hYiUDwiTL9FO03jyclFJD")).Click();//arama çubuğuna tıkla
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.ClassName("_1hYiUDwiTL9FO03jyclFJD")).SendKeys("****");
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[2]/div/div[2]/i")).Click();//arama
                System.Threading.Thread.Sleep(5000);

                if (driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div")) != null)
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[1]/div[1]/div/div[1]")).Click();//hepsini secme
                    System.Threading.Thread.Sleep(5000);
                    //driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[3]/div/div/div/div/div/ul/button[5]")).Click();//tasi
                    //System.Threading.Thread.Sleep(5000);
                    driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[1]/div/div/div/div/div[1]/div[3]")).Click();//gereksiz olarak işaretle
                    System.Threading.Thread.Sleep(5000);
                    driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div/div/div/ul/li[1]")).Click();
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("***** adli kisinin mailleri gereksiz olarak işaretlendi");

                    //Gereksizler
                    driver.FindElement(By.XPath("//*[@id='app']/div/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div[3]/div")).Click();//gereksizler,
                    System.Threading.Thread.Sleep(5000);
                    driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[3]/div[1]/div/div/div/div/div[1]/div[1]")).Click();//tumunu sil
                    System.Threading.Thread.Sleep(5000);
                    driver.FindElement(By.XPath("//*[@id='ok-1']")).Click();
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Gereksiz klasorundekiler silinmistir ");

                    driver.Close();


                }
            }

        }
    }

