using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectandWait.Pages;

public class Program
{
    private static void Main(string[]args)
    {
    //Open Chrome browser
    IWebDriver driver = new ChromeDriver(); //instance of a browser
        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAction(driver);

        //Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //Time and material page object initialization and definition
        TMPage TMPageObj = new TMPage();

        //Create
        TMPageObj.Create_TimeRecord(driver);
        //Edit
        TMPageObj.Update_TimeRecord(driver);
        //Delete
        TMPageObj.Delete_TimeRecord(driver);



    }
}






