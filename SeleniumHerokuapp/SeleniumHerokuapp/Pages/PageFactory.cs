﻿using System;
using OpenQA.Selenium;

namespace SeleniumHerokuapp.Pages
{
    public class PageFactory
    {
        public PageFactory(Type driverType, bool isHeadless = false,
            int elementWaitTime = 0, int pageWaitTime = -1)
        {
            Driver = new DriverConfig(driverType,
                isHeadless, elementWaitTime, pageWaitTime).Driver;

            SharedIAlert = new SharedIAlert(Driver);
            SharedHTML = new SharedHTML(Driver);

            IndexPage = new IndexPage(Driver);
            AddRemoveElementsPage = new AddRemoveElementsPage(Driver);
            BasicAuthenticationPage = new BasicAuthenticationPage(Driver);
            BrokenImagesPage = new BrokenImagesPage(Driver);
            CheckboxesPage = new CheckboxesPage(Driver);
            DigestAuthenticationPage = new DigestAuthenticationPage(Driver);
            DragAndDropPage = new DragAndDropPage(Driver);
            DropdownPage = new DropdownPage(Driver);
            EntryAdPage = new EntryAdPage(Driver);
            FormAuthenticationPage = new FormAuthenticationPage(Driver);
            FramesPage = new FramesPage(Driver);
            HoversPage = new HoversPage(Driver);
            InputsPage = new InputsPage(Driver);
            JavaScriptAlertsPage = new JavaScriptAlertsPage(Driver);
            KeyPressesPage = new KeyPressesPage(Driver);
            NestedFramesPage = new NestedFramesPage(Driver);
        }

        public IWebDriver Driver { get; private set; }

        public SharedHTML SharedHTML { get; private set; }

        public SharedIAlert SharedIAlert { get; private set; }

        public IndexPage IndexPage { get; private set; }

        public AddRemoveElementsPage AddRemoveElementsPage { get; private set; }

        public BasicAuthenticationPage BasicAuthenticationPage { get; private set; }

        public BrokenImagesPage BrokenImagesPage { get; private set; }

        public CheckboxesPage CheckboxesPage { get; private set; }

        public DigestAuthenticationPage DigestAuthenticationPage { get; private set; }

        public DragAndDropPage DragAndDropPage { get; private set; }

        public DropdownPage DropdownPage { get; private set; }

        public EntryAdPage EntryAdPage { get; private set; }

        public FormAuthenticationPage FormAuthenticationPage { get; private set; }

        public FramesPage FramesPage { get; private set; }

        public HoversPage HoversPage { get; private set; }

        public InputsPage InputsPage { get; private set; }

        public JavaScriptAlertsPage JavaScriptAlertsPage { get; private set; }

        public KeyPressesPage KeyPressesPage { get; private set; }

        public NestedFramesPage NestedFramesPage { get; private set; }

        public void NavigateToInvalidPage()
        {
            Driver.Navigate().GoToUrl(ConfigReader.Index + ConfigReader.Invalid);
        }

        public void CloseDriver() => Driver.Quit();

        public void DeleteAllCookies() => Driver.Manage().Cookies.DeleteAllCookies();
    }
}
