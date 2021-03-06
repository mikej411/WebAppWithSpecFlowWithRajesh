﻿using OpenQA.Selenium;

namespace WebApp.AppFramework
{
    public class HomePageBys
    {     
        public readonly By EmailTxt = By.Id("es_txt_email");

        


        // Locator examples
        public readonly By a = By.CssSelector("button.app-navbar-toggle.collapsed");
        public readonly By c = By.CssSelector("button[data-id='person-filter']");
        public readonly By z = By.XPath("//*[@id='person-grid']/tbody"); 
        public readonly By x = By.XPath("(//div[@id='person_tooltip'])[1]");
        public readonly By v = By.XPath("//span[contains(.,'Delete Person')]");       
        public readonly By b = By.XPath("//button[@id='items-lnk']/span[1]");
        public readonly By n = By.XPath("//div[@class='bootstrap-dialog-header']/div[@class='bootstrap-dialog-close-button']");
        public readonly By m = By.XPath("//button[@id='filters-demos']/..");
        public readonly By s = By.XPath("//li[@id='webapp-menu-person']/a");

        // Locator examples that can be used in the Page or Test classes
        // Find a parent element
        //IWebElement parentElem = childElem.FindElement(By.XPath(".."));
        
        // This XPath line selects the first TD element with the exact text (or that contains the text) that is in the orgName variable
        //string xPathVariable = "//td[./text()='yourtext']";
        //string xPathVariable = "//td[contains(text(),'yourtext')]";
        //string xPathVariable = string.Format("//div[contains(.,'{0}')]", textOfCell);
        //IWebElement organizationNameTDCell = gridElem.FindElement(By.XPath(xPathVariable));

        // Mulitple elements or multiple attributes
        //string xpathString = string.Format("//span[text()='{0}' and @class=\"ui-iggrid-headertext\"]", textOfHeaderCell);

        // Attribute does not equal
        //IWebElement lists = Browser.FindElement(By.CssSelector("li:not([class=hidden])"));
    }
}