using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void autoplay_pacman()
        {
            // Open the windows application driver
            System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");

            // Create a new session to bring up the test application
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"C:\\Users\\Youjin Li\\Desktop\\GitRepo\\CPSC5210-TEAM7\\Pacman_Zagorschi_Franco\\bin\\Debug\\Pacman_Zagorschi_Franco.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>
                (new Uri("http://127.0.0.1:4723"), options);

            Thread.Sleep(1000);

            // Test if the welcome panel successfuly launched
            var res = driver.FindElementByAccessibilityId("label142").Text;
            Assert.AreEqual(res, "Muhammad Akbar Priambodo ");

            // Start the game
            driver.FindElementByAccessibilityId("button1").Click();

            // Pacman will randomly go 4 directions.
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            Thread.Sleep(1000);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);

            // 2 life left here 
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);

            // 1 life left here
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            Thread.Sleep(100);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            Thread.Sleep(5000);

            // close the session
            driver.Close();
        }

        [TestMethod]
        public void start_game_show_authorName()
        {
            // Open the windows application driver
            System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");

            // Create a new session to bring up the test application
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"C:\\Users\\Youjin Li\\Desktop\\GitRepo\\CPSC5210-TEAM7\\Pacman_Zagorschi_Franco\\bin\\Debug\\Pacman_Zagorschi_Franco.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>
                (new Uri("http://127.0.0.1:4723"), options);

            Thread.Sleep(1000);

            // Test if the welcome panel successfuly launched
            var res = driver.FindElementByAccessibilityId("label142").Text;
            Assert.AreEqual(res, "Muhammad Akbar Priambodo ");

            // Start the game
            driver.FindElementByAccessibilityId("button1").Click();


            // close the session
            driver.Close();
        }

        [TestMethod]
        public void kill_game_when_running_show_version_number()
        {
            // Open the windows application driver
            System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");

            // Create a new session to bring up the test application
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"C:\\Users\\Youjin Li\\Desktop\\GitRepo\\CPSC5210-TEAM7\\Pacman_Zagorschi_Franco\\bin\\Debug\\Pacman_Zagorschi_Franco.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            var driver = new WindowsDriver<WindowsElement>
                (new Uri("http://127.0.0.1:4723"), options);

            Thread.Sleep(1000);

            // Test if the welcome panel successfuly launched
            var res = driver.FindElementByAccessibilityId("label254").Text;
            Assert.AreEqual(res, "(15050623024)");

            // Start the game
            driver.FindElementByAccessibilityId("button1").Click();

            // Pacman will randomly go 4 directions.
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Right);
            Thread.Sleep(1000);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Left);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Up);

            // kill the process when the gaming is running
            driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Escape);

        }
    }
}
