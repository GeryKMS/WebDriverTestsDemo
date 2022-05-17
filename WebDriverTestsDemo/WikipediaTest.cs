

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Create new ChromBraser instance
var driver = new ChromeDriver();

// Navigate ti Wikipedia
driver.Url = "https://wikipedoa.org";

// Locate Search field by ID
var searchField = driver.FindElement(By.Id("searchInput"));

// Clik on element
searchField.Click();

// fill QA and press ENTER keybord button
searchField.SendKeys("QA");
searchField.SendKeys(Keys.Enter);

System.Console.WriteLine("TITEL AFTER SEARCH: " + driver.Title);

//Close browser
driver.Quit();