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
            var lblPrijs = UiHelper.GetLabel(window, "lblPrijs");
            var lblAantal = UiHelper.GetLabel(window, "lblAantal");
            var lblTeBetalen = UiHelper.GetLabel(window, "lblTeBetalen");
            var btnWissen = UiHelper.GetButton(window, "btnWissen");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var txtPrijs = UiHelper.GetTextBox(window, "txtPrijs");
            var txtAantal = UiHelper.GetTextBox(window, "txtAantal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");
            app.Close();

            Assert.NotNull(lblPrijs);
            Assert.NotNull(lblAantal);
            Assert.NotNull(lblTeBetalen);
            Assert.NotNull(btnWissen);
            Assert.NotNull(btnBereken);
            Assert.NotNull(btnSluiten);
            Assert.NotNull(txtPrijs);
            Assert.NotNull(txtAantal);
            Assert.NotNull(lblResultaat);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblPrijs = UiHelper.GetLabel(window, "lblPrijs");
            var lblAantal = UiHelper.GetLabel(window, "lblAantal");
            var lblTeBetalen = UiHelper.GetLabel(window, "lblTeBetalen");
            var btnWissen = UiHelper.GetButton(window, "btnWissen");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var txtPrijs = UiHelper.GetTextBox(window, "txtPrijs");
            var txtAantal = UiHelper.GetTextBox(window, "txtAantal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtPrijs.Text = "10,5";
            txtAantal.Text = "5";
            btnBereken.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("52,50", result);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblPrijs = UiHelper.GetLabel(window, "lblPrijs");
            var lblAantal = UiHelper.GetLabel(window, "lblAantal");
            var lblTeBetalen = UiHelper.GetLabel(window, "lblTeBetalen");
            var btnWissen = UiHelper.GetButton(window, "btnWissen");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var txtPrijs = UiHelper.GetTextBox(window, "txtPrijs");
            var txtAantal = UiHelper.GetTextBox(window, "txtAantal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtPrijs.Text = "14,80";
            txtAantal.Text = "3";
            btnBereken.Click();
            var result = lblResultaat.Text;
            app.Close();

            Assert.Contains("44,40", result);
        }

        [Fact]
        public void CorrecteFunctionaliteit3()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblPrijs = UiHelper.GetLabel(window, "lblPrijs");
            var lblAantal = UiHelper.GetLabel(window, "lblAantal");
            var lblTeBetalen = UiHelper.GetLabel(window, "lblTeBetalen");
            var btnWissen = UiHelper.GetButton(window, "btnWissen");
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var txtPrijs = UiHelper.GetTextBox(window, "txtPrijs");
            var txtAantal = UiHelper.GetTextBox(window, "txtAantal");
            var lblResultaat = UiHelper.GetLabel(window, "lblResultaat");

            txtPrijs.Text = "14,80";
            txtAantal.Text = "3";
            btnWissen.Click();
            var resultPrijs = txtPrijs.Text;
            var resultAantal = txtAantal.Text;
            var resultResultaat = lblResultaat.Text;
            app.Close();

            Assert.Contains(string.Empty, resultPrijs);
            Assert.Contains(string.Empty, resultAantal);
            Assert.Contains(string.Empty, resultResultaat);
        }
    }
}