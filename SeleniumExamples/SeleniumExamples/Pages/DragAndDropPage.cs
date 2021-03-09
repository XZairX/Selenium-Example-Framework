﻿using System;
using System.IO;
using OpenQA.Selenium;

namespace SeleniumExamples.Pages
{
    public sealed class DragAndDropPage : WebPage, IPageNavigation
    {
        public DragAndDropPage(IWebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            NavigateToURL(ConfigReader.Index + ConfigReader.DragAndDrop);
        }

        private IWebElement ColumnA => Driver.FindElement(By.Id("column-a"));
        
        private IWebElement ColumnB => Driver.FindElement(By.Id("column-b"));

        private IWebElement ColumnAHeader =>
            Driver.FindElement(By.CssSelector("#column-a > header"));

        private IWebElement ColumnBHeader =>
            Driver.FindElement(By.CssSelector("#column-b > header"));

        public void SwapPositions()
        {
            StreamReader jsFile = new StreamReader(AppContext.BaseDirectory + @"Helpers\simulate-drag-drop.js");
            
            string jsContents = jsFile.ReadToEnd();
            
            ((IJavaScriptExecutor)Driver).ExecuteScript(jsContents +
                "simulateDragDrop({sourceNode: '#{ColumnA}'}, {destinationNode: '#{ColumnB}'})");
        }
        
        public bool HaveColumnPositionsBeenSwapped()
        {
            return ColumnAHeader.Text != "A";
            //32 //247
        }
    }
}
