﻿using NUnit.Framework;
using SeleniumHerokuapp.Pages;
using TechTalk.SpecFlow;

namespace SeleniumHerokuapp.Steps
{
    [Binding]
    public class IndexSteps
    {
        private readonly PageFactory _sut;

        public IndexSteps(PageFactory sut) => _sut = sut;

        [Given(@"the user is on the Index page")]
        public void GivenTheUserIsOnTheIndexPage()
        {
            _sut.IndexPage.NavigateToPage();
        }

        [When(@"the user clicks the link in the footer of the page")]
        public void WhenTheUserClicksTheLinkInTheFooterOfThePage()
        {
            _sut.SharedHTML.ClickPageFooterLink();
        }

        [When(@"the user clicks the GitHub image")]
        public void WhenTheUserClicksTheGitHubImage()
        {
            _sut.SharedHTML.ClickGitHubImageLink();
        }

        [When(@"the user clicks the Add/Remove Elements link")]
        public void WhenTheUserClicksTheAddRemoveElementsLink()
        {
            _sut.IndexPage.ClickAddRemoveElementsLink();
        }

        [When(@"the user clicks the Basic Authentication link")]
        public void WhenTheUserClicksTheBasicAuthenticationLink()
        {
            _sut.IndexPage.ClickBasicAuthenticationLink();
        }

        [When(@"the user clicks the Broken Images link")]
        public void WhenTheUserClicksTheBrokenImagesLink()
        {
            _sut.IndexPage.ClickBrokenImagesLink();
        }

        [When(@"the user clicks the Checkboxes link")]
        public void WhenTheUserClicksTheCheckboxesLink()
        {
            _sut.IndexPage.ClickCheckboxesLink();
        }

        [When(@"the user clicks the Digest Authentication link")]
        public void WhenTheUserClicksTheDigestAuthenticationLink()
        {
            _sut.IndexPage.ClickDigestAuthenticationLink();
        }

        [When(@"the user clicks the Drag and Drop link")]
        public void WhenTheUserClicksTheDragAndDropLink()
        {
            _sut.IndexPage.ClickDragAndDropLink();
        }

        [When(@"the user clicks the Dropdown link")]
        public void WhenTheUserClicksTheDropdownLink()
        {
            _sut.IndexPage.ClickDropdownLink();
        }

        [When(@"the user clicks the Form Authentication link")]
        public void WhenTheUserClicksTheFormAuthenticationLink()
        {
            _sut.IndexPage.ClickFormAuthenticationLink();
        }

        [When(@"the user clicks the Frames link")]
        public void WhenTheUserClicksTheFramesLink()
        {
            _sut.IndexPage.ClickFramesLink();
        }

        [When(@"the user clicks the Hovers link")]
        public void WhenTheUserClicksTheHoversLink()
        {
            _sut.IndexPage.ClickHoversLink();
        }

        [When(@"the user clicks the JavaScript Alerts link")]
        public void WhenTheUserClicksTheJavaScriptAlertsLink()
        {
            _sut.IndexPage.ClickJavaScriptAlertsLink();
        }

        [When(@"the user clicks the Nested Frames link")]
        public void WhenTheUserClicksTheNestedFramesLink()
        {
            _sut.IndexPage.ClickNestedFramesLink();
        }

        [When(@"the user switches to the newly created tab (.*)")]
        public void WhenTheUserSwitchesToTheNewlyCreatedTab(int index)
        {
            _sut.SharedHTML.SwitchToTab(index);
        }

        [Then(@"the page url should indicate that the user has been redirected to the correct ""(.*)"" website")]
        public void ThenThePageUrlShouldIndicateThatTheUserHasBeenRedirectedToTheCorrectWebsite(string url)
        {
            var result = _sut.Driver.Url;

            Assert.That(result, Is.EqualTo(url));
        }

        [Then(@"the page header text should inform the user that they are on the correct ""(.*)"" page")]
        public void ThenThePageHeaderTextShouldInformTheUserThatTheyAreOnTheCorrectPage(string pageHeader)
        {
            var result = _sut.SharedHTML.ReadPageHeaderText();

            Assert.That(result, Is.EqualTo(pageHeader));
        }

        [Then(@"the popup text should inform the user that they are attempting to reach the correct ""(.*)"" page")]
        public void ThenThePopupTextShouldInformTheUserThatTheyAreAttemptingToReachTheCorrectPage(string pageAuthenticationArea)
        {
            var result = _sut.SharedIAlert.ReadAuthenticationPopupText();

            Assert.That(result, Is.EqualTo(pageAuthenticationArea));
        }

        [Then(@"the page url should inform the user that they are on the correct ""(.*)"" page")]
        public void ThenThePageUrlShouldInformTheUserThatTheyAreOnTheCorrectPage(string url)
        {
            var result = _sut.Driver.Url;

            Assert.That(result, Is.EqualTo(ConfigReader.Index + url));
        }
    }
}
