using System;
using Xunit;

namespace oefening_05_test
{
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-05-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var txtMaaltafel = UiHelper.GetTextBox(window, "txtMaaltafel");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");
            app.Close();

            Assert.NotNull(txtMaaltafel);
            Assert.NotNull(btnBereken);
            Assert.NotNull(lblResultaat);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var txtMaaltafel = UiHelper.GetTextBox(window, "txtMaaltafel");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtMaaltafel.Text = "4";
            btnBereken.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("0 x 4 = 0", result);
            Assert.Contains("1 x 4 = 4", result);
            Assert.Contains("2 x 4 = 8", result);
            Assert.Contains("3 x 4 = 12", result);
            Assert.Contains("4 x 4 = 16", result);
            Assert.Contains("5 x 4 = 20", result);
            Assert.Contains("6 x 4 = 24", result);
            Assert.Contains("7 x 4 = 28", result);
            Assert.Contains("8 x 4 = 32", result);
            Assert.Contains("9 x 4 = 36", result);
            Assert.Contains("10 x 4 = 40", result);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var txtMaaltafel = UiHelper.GetTextBox(window, "txtMaaltafel");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtMaaltafel.Text = "6";
            btnBereken.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("0 x 6 = 0", result);
            Assert.Contains("1 x 6 = 6", result);
            Assert.Contains("2 x 6 = 12", result);
            Assert.Contains("3 x 6 = 18", result);
            Assert.Contains("4 x 6 = 24", result);
            Assert.Contains("5 x 6 = 30", result);
            Assert.Contains("6 x 6 = 36", result);
            Assert.Contains("7 x 6 = 42", result);
            Assert.Contains("8 x 6 = 48", result);
            Assert.Contains("9 x 6 = 54", result);
            Assert.Contains("10 x 6 = 60", result);
        }
    }
}