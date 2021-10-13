using System;
using Xunit;

namespace oefening_02_test
{
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-02-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBereken");
            var txtStraal = UiHelper.GetTextBox(window, "txtStraal");
            var lblStraal = UiHelper.GetTextBox(window, "lblStraal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");
            app.Close();

            Assert.NotNull(btnBerekenen);
            Assert.NotNull(txtStraal);
            Assert.NotNull(lblStraal);
            Assert.NotNull(lblResultaat);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBereken");
            var txtStraal = UiHelper.GetTextBox(window, "txtStraal");
            var lblStraal = UiHelper.GetTextBox(window, "lblStraal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtStraal.Text = "3";
            btnBerekenen.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("18,85", result);
            Assert.Contains("28,27", result);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBereken");
            var txtStraal = UiHelper.GetTextBox(window, "txtStraal");
            var lblStraal = UiHelper.GetTextBox(window, "lblStraal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtStraal.Text = "5";
            btnBerekenen.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("31,42", result);
            Assert.Contains("78,54", result);
        }
    }
}