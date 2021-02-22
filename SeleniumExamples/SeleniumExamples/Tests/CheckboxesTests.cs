﻿using NUnit.Framework;
using SeleniumExamples.Pages;

namespace SeleniumExamples
{
    [TestFixture]
    public class CheckboxesTests
    {
        private WebsitePOM _sut;

        [OneTimeSetUp]
        public void OneTimeSetUp() => _sut = new WebsitePOM();

        [OneTimeTearDown]
        public void OneTimeTearDown() => _sut.CloseDriver();

        [Test]
        public void ClickCheckbox1_TogglesCheckboxesTick()
        {
            _sut.NavigateToCheckboxesPage();

            _sut.CheckboxesPage.ClickCheckBox(1);
            var result = _sut.CheckboxesPage.IsCheckBoxTicked(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ClickCheckbox2_TogglesCheckboxesTick()
        {
            _sut.NavigateToCheckboxesPage();

            _sut.CheckboxesPage.ClickCheckBox(2);
            var result = _sut.CheckboxesPage.IsCheckBoxTicked(2);

            Assert.That(result, Is.False);
        }
    }
}
