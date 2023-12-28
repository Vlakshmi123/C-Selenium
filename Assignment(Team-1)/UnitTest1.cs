using AngleSharp.Dom;
using AngleSharp.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment_Team_1_
{
    public class Tests
    {
        private IWebDriver driver;
        Boolean badge;
        [SetUp]
        public void Setup()
        {


            // Set up Chrome driver            

            string driverpath = @"C:\Users\VaralakshmiYadav(Ann\source\repos\Assignment(Team-1)\Assignment(Team-1)\bin\Debug\net6.0";

            driver = new ChromeDriver(driverpath);

            driver.Navigate().GoToUrl("https://devomni.annalect.com/login");


            driver.Manage().Window.Maximize();

            // Login to Devomni

            var shadowHost1 = driver.FindElement(By.CssSelector("#portal-login > portal-login"));

            var shadowRoot1 = shadowHost1.GetShadowRoot();

            IWebElement UsernameTextfield = shadowRoot1.FindElement(By.CssSelector("#username"));

            UsernameTextfield.SendKeys("adminqa.test@annalect.com");

            var shadowRoot2 = shadowHost1.GetShadowRoot();

            IWebElement signin = shadowRoot2.FindElement(By.CssSelector("#eid-login-btn"));

            signin.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300000);

            var shadowHost2 = shadowRoot1.FindElement(By.CssSelector("form > div.password > portal-password"));

            var shadowRoot3 = shadowHost2.GetShadowRoot();

            IWebElement PasswordTextfield = shadowRoot3.FindElement(By.CssSelector("#password"));

            PasswordTextfield.SendKeys("4`>7s`^w2XeE}|");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300000);
            Thread.Sleep(10000);
            signin.Click();


        }

        [Test]
        public void DevOmniLoginTest()
        {
            Thread.Sleep(10000);
            Assert.That(driver.Url.Contains("my-workspace"));
        }
        // click on All tools menu and take screenshot
        [Test]
        public void AllToolsBtnClick_Test()
        {
            var shadowHost3 = driver.FindElement(By.CssSelector("#outlet > portal-app-container")).GetShadowRoot();

            var shadowHost4 = shadowHost3.FindElement(By.CssSelector("#nav-background > portal-nav-menu")).GetShadowRoot();

            var shadowHost5 = shadowHost4.FindElement(By.CssSelector("omni-style > omni-nav-menu")).GetShadowRoot();

            var shadowHost6 = shadowHost5.FindElement(By.CssSelector("#All-Tools > omni-tooltip > div:nth-child(1) > a > omni-icon")).GetShadowRoot();

            IWebElement BtnAlltools = shadowHost6.FindElement(By.CssSelector("div > svg"));

            Thread.Sleep(10000);

            BtnAlltools.Click();
            Thread.Sleep(10000);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Screenshots\\Alltoolsscreenshot.png");
            Thread.Sleep(10000);


        }
        [Test]
        public void CampaignBtnClick()
        {
            var shadowHost3 = driver.FindElement(By.CssSelector("#outlet > portal-app-container")).GetShadowRoot();

            var shadowHost4 = shadowHost3.FindElement(By.CssSelector("#nav-background > portal-nav-menu")).GetShadowRoot();

            var shadowHost5 = shadowHost4.FindElement(By.CssSelector("omni-style > omni-nav-menu")).GetShadowRoot();
            var shadowHost6 = shadowHost5.FindElement(By.CssSelector("#Campaigns > omni-tooltip > div:nth-child(1) > a > omni-icon")).GetShadowRoot();

            IWebElement BtnCampaigns = shadowHost6.FindElement(By.CssSelector("div > svg"));
            Thread.Sleep(10000);

            BtnCampaigns.Click();
            Thread.Sleep(10000);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Screenshots\\Campaignscreenshot.png");
            Thread.Sleep(10000);
        }
        [Test]
        public void AudienceBtnClick()
        {
            var shadowHost3 = driver.FindElement(By.CssSelector("#outlet > portal-app-container")).GetShadowRoot();

            var shadowHost4 = shadowHost3.FindElement(By.CssSelector("#nav-background > portal-nav-menu")).GetShadowRoot();

            var shadowHost5 = shadowHost4.FindElement(By.CssSelector("omni-style > omni-nav-menu")).GetShadowRoot();
            var shadowHost6 = shadowHost5.FindElement(By.CssSelector("#Audiences > omni-tooltip > div:nth-child(1) > a > omni-icon")).GetShadowRoot();

            IWebElement BtnCampaigns = shadowHost6.FindElement(By.CssSelector("div > svg"));
            Thread.Sleep(10000);

            BtnCampaigns.Click();
            Thread.Sleep(10000);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Screenshots\\Audiencescreenshot.png");
            Thread.Sleep(10000);
        }
        [Test]
        public void ReportBtnClick()
        {
            var shadowHost3 = driver.FindElement(By.CssSelector("#outlet > portal-app-container")).GetShadowRoot();

            var shadowHost4 = shadowHost3.FindElement(By.CssSelector("#nav-background > portal-nav-menu")).GetShadowRoot();

            var shadowHost5 = shadowHost4.FindElement(By.CssSelector("omni-style > omni-nav-menu")).GetShadowRoot();
            var shadowHost6 = shadowHost5.FindElement(By.CssSelector("#Reports > omni-tooltip > div:nth-child(1) > a > omni-icon")).GetShadowRoot();

            IWebElement BtnCampaigns = shadowHost6.FindElement(By.CssSelector("div > svg"));
            Thread.Sleep(10000);

            BtnCampaigns.Click();
            Thread.Sleep(10000);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
           // object value = ss.AddURLToImage("C:\\Screenshots\\.png").SaveAsFile("C:\\Screenshots\\.png");
            ss.SaveAsFile("C:\\Screenshots\\ReportsScreenshot.png");
            Thread.Sleep(10000);
        }
        [Test]
        public void SignOutBtnClick()
        {
            var shadowHost3 = driver.FindElement(By.CssSelector("#outlet > portal-app-container")).GetShadowRoot();
            var shadowHost4 = driver.FindElement(By.CssSelector("portal-user-selection-menu")).GetShadowRoot();
            var shadowHost5 = driver.FindElement(By.CssSelector("portal-user-button[aria-haspopup='menu']")).GetShadowRoot();
            IWebElement AdminQA = shadowHost5.FindElement(By.CssSelector("button is-text is-rounded is-capitalized is-size-3 has-text-weight-normal"));
            Thread.Sleep(10000);
            AdminQA.Click();
        }

        [Test]
        public void CheckFoundationCertificate()
        {
            
            var shadow0 = driver.FindElement(By.CssSelector("portal-app-container")).GetShadowRoot();
            Thread.Sleep(10000);
            var shadow1 = shadow0.FindElement(By.CssSelector("portal-user-selection-menu")).GetShadowRoot();
            Thread.Sleep(10000);
            var shadow2 = shadow1.FindElement(By.CssSelector("portal-user-button[aria-haspopup='menu']")).GetShadowRoot();
            Thread.Sleep(10000);
            var shadow3 = shadow2.FindElement(By.CssSelector("portal-user-image")).GetShadowRoot();
            Thread.Sleep(10000);
            var shadow4 = shadow3.FindElement(By.CssSelector(".is-size-4")).GetShadowRoot();
            Thread.Sleep(10000);
            IWebElement OmniFoundtnBadge = shadow4.FindElement(By.CssSelector("div[part='badge']"));
            
            if(badge==true)
            {
                Console.WriteLine("User is Omni certified");
            }
            else
            {
                Console.WriteLine("User is not Omni certified");
            }
        }

        [TearDown]
        public void TearDown()

        {
            driver.Quit();
        }
    }
}