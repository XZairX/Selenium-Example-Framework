﻿using NUnit.Framework;
using SeleniumHerokuapp.Pages;

namespace SeleniumHerokuapp.Tests
{
    [TestFixture]
    public class DigestAuthenticationTests
    {
        private PageFactory _sut;

        [Ignore("Authentication alerts cannot be interacted with in ChromeDriver")]
        [Test]
        public void ClickCancelButton_RedirectsToEmptyPage()
        {
            _sut = new PageFactory(StaticDriver.Type);
            _sut.DigestAuthenticationPage.NavigateToAuthentication();

            _sut.SharedIAlert.ClickCancelButton();
            var result = _sut.SharedHTML.ReadPageBodyText();

            Assert.That(result, Is.Empty);

            _sut.CloseDriver();
        }

        [Test]
        public void ClickOKButton_ValidCredentials_RedirectsToDigestAuthenticationPage()
        {
            _sut = new PageFactory(StaticDriver.Type);
            _sut.DigestAuthenticationPage.NavigatePastAuthentication();
            
            var result = _sut.SharedHTML.ReadPageHeaderText();

            Assert.That(result, Is.EqualTo("Digest Auth"));

            _sut.CloseDriver();
        }

        [Test]
        public void AuthenticatedUser_CloseSessionTab_AuthenticationSessionPersistsWithinWindow()
        {
            _sut = new PageFactory(StaticDriver.Type);
            _sut.DigestAuthenticationPage.NavigatePastAuthentication();

            _sut.SharedHTML.OpenNewTab();
            _sut.SharedHTML.CloseTab(0);
            _sut.SharedHTML.SwitchToTab(0);
            _sut.DigestAuthenticationPage.NavigateToAuthentication();
            var result = _sut.SharedHTML.ReadPageHeaderText();

            Assert.That(result, Is.EqualTo("Digest Auth"));

            _sut.CloseDriver();
        }
    }
}
