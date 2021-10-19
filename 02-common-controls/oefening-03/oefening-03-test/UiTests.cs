using System;
using Xunit;

namespace oefening_03_test
{
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-03-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnAfdrukken = UiHelper.GetButton(window, "btnAfdrukken");
            var cbFoutieveRecords = UiHelper.GetCheckBox(window, "cbFoutieveRecords");
            var cbGeldigeRecords = UiHelper.GetCheckBox(window, "cbGeldigeRecords");
            var lblFoutieveRecords = UiHelper.GetLabel(window, "lblFoutieveRecords");
            var lblGeldigeRecords = UiHelper.GetCheckBox(window, "lblGeldigeRecords");
            app.Close();

            Assert.NotNull(btnAfdrukken);
            Assert.NotNull(cbFoutieveRecords);
            Assert.NotNull(cbGeldigeRecords);
            Assert.NotNull(lblFoutieveRecords);
            Assert.NotNull(lblGeldigeRecords);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnAfdrukken = UiHelper.GetButton(window, "btnAfdrukken");
            var cbFoutieveRecords = UiHelper.GetCheckBox(window, "cbFoutieveRecords");
            var cbGeldigeRecords = UiHelper.GetCheckBox(window, "cbGeldigeRecords");
            var lblFoutieveRecords = UiHelper.GetLabel(window, "lblFoutieveRecords");
            var lblGeldigeRecords = UiHelper.GetCheckBox(window, "lblGeldigeRecords");
            cbGeldigeRecords.Click();
            btnAfdrukken.Click();
            var geldigeRecordsText = lblGeldigeRecords.Text;
            app.Close();

            Assert.Contains("ts@test.be", geldigeRecordsText);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnAfdrukken = UiHelper.GetButton(window, "btnAfdrukken");
            var cbFoutieveRecords = UiHelper.GetCheckBox(window, "cbFoutieveRecords");
            var cbGeldigeRecords = UiHelper.GetCheckBox(window, "cbGeldigeRecords");
            var lblFoutieveRecords = UiHelper.GetLabel(window, "lblFoutieveRecords");
            var lblGeldigeRecords = UiHelper.GetCheckBox(window, "lblGeldigeRecords");
            cbFoutieveRecords.Click();
            btnAfdrukken.Click();
            var foutieveRecordsText = lblFoutieveRecords.Text;
            app.Close();

            Assert.Contains("jvstest.be", foutieveRecordsText);
        }

        [Fact]
        public void CorrecteFunctionaliteit3()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnAfdrukken = UiHelper.GetButton(window, "btnAfdrukken");
            var cbFoutieveRecords = UiHelper.GetCheckBox(window, "cbFoutieveRecords");
            var cbGeldigeRecords = UiHelper.GetCheckBox(window, "cbGeldigeRecords");
            var lblFoutieveRecords = UiHelper.GetLabel(window, "lblFoutieveRecords");
            var lblGeldigeRecords = UiHelper.GetCheckBox(window, "lblGeldigeRecords");
            cbFoutieveRecords.Click();
            cbGeldigeRecords.Click();
            btnAfdrukken.Click();
            var foutieveRecordsText = lblFoutieveRecords.Text;
            var geldigeRecordsText = lblGeldigeRecords.Text;
            app.Close();

            Assert.Contains("jvstest.be", foutieveRecordsText);
            Assert.Contains("ts@test.be", geldigeRecordsText);
        }
    }
}