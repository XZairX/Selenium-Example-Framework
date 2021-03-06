﻿using System;
using System.IO;
using OpenQA.Selenium;

namespace SeleniumHerokuapp.Pages
{
    public sealed class DragAndDropPage : WebPage, IPageNavigation
    {
        public DragAndDropPage(IWebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            NavigateToURL(ConfigReader.Index + ConfigReader.DragAndDrop);
        }

        private IWebElement ColumnAHeader =>
            Driver.FindElement(By.CssSelector("#column-a > header"));

        public void SwapDraggableContents()
        {
            try
            {
                string jsContents = File.ReadAllText(
                    AppContext.BaseDirectory + @"Helpers\simulate-drag-drop.js");

                ((IJavaScriptExecutor)Driver).ExecuteScript(jsContents +
                    "$('#column-a').simulateDragDrop({dropTarget: '#column-b'});");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to complete operation. File not found.");
            }
        }

        public bool HaveDraggableContentsBeenSwapped()
        {
            return ColumnAHeader.Text != "A";
        }
    }
}
