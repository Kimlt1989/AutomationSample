using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace TestTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string appiumDriverURI = "http://127.0.0.1:4723";
        private const string noteApp = @"C:\Windows\System32\notepad.exe";
        protected static WindowsDriver<WindowsElement> NotepadSession;
        private WindowsDriver<WindowsElement> session;

        [TestMethod]
        public void TestMethod1()
        {
      /*      // Launch Notepad
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", noteApp);
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            //Create a session to intract with windows application  
            NotepadSession = new WindowsDriver<WindowsElement>(new Uri(appiumDriverURI), appCapabilities);*/

            AppiumOptions opt = new AppiumOptions();
            opt.AddAdditionalCapability("app", noteApp);
            opt.AddAdditionalCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri(appiumDriverURI), opt);

            // Control the  app
            session.FindElementByClassName("Edit").SendKeys("This is some text");

        }
    }
}
