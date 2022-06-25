using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnpluggingSocialMedias.Core.Services.Whatsapp;

public class WhatsAppDeserializerService
{

    public WhatsAppDeserializerService()
    {
        var url = "https://web.whatsapp.com/";
        var chromeDriver = new ChromeDriver();

        chromeDriver.Navigate().GoToUrl(url);
        chromeDriver.Manage().Window.Maximize();

        //class="_1pJ9J"

        var notRead = chromeDriver.FindElement(By.ClassName("_1pJ9J"));
        var enterChat = notRead.FindElement(By.XPath("//span[@aria-label='1 mensagem não lida'"));
        enterChat.Click();

        var message = chromeDriver.GetScreenshot();

        //email




    }
}