using System;
using Xunit;

namespace oefening_04_test
{
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-04-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblAchternaam = UiHelper.GetLabel(window, "lblAchternaam");
            var lblVoornaam = UiHelper.GetLabel(window, "lblVoornaam");
            var lblVerdiensten = UiHelper.GetLabel(window, "lblVerdiensten");
            var btnToevoegen = UiHelper.GetButton(window, "btnToevoegen");
            var txtAchternaam = UiHelper.GetTextBox(window, "txtAchternaam");
            var txtVoornaam = UiHelper.GetTextBox(window, "txtVoornaam");
            var txtVerdiensten = UiHelper.GetLabel(window, "txtVerdiensten");
            var txtWerknemers = UiHelper.GetLabel(window, "txtWerknemers");
            app.Close();

            Assert.NotNull(lblAchternaam);
            Assert.NotNull(lblVoornaam);
            Assert.NotNull(lblVerdiensten);
            Assert.NotNull(btnToevoegen);
            Assert.NotNull(txtAchternaam);
            Assert.NotNull(txtVoornaam);
            Assert.NotNull(txtVerdiensten);
            Assert.NotNull(txtWerknemers);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblAchternaam = UiHelper.GetLabel(window, "lblAchternaam");
            var lblVoornaam = UiHelper.GetLabel(window, "lblVoornaam");
            var lblVerdiensten = UiHelper.GetLabel(window, "lblVerdiensten");
            var btnToevoegen = UiHelper.GetButton(window, "btnToevoegen");
            var txtAchternaam = UiHelper.GetTextBox(window, "txtAchternaam");
            var txtVoornaam = UiHelper.GetTextBox(window, "txtVoornaam");
            var txtVerdiensten = UiHelper.GetTextBox(window, "txtVerdiensten");
            var txtWerknemers = UiHelper.GetTextBox(window, "txtWerknemers");

            txtAchternaam.Text = "Synaeve";
            txtVoornaam.Text = "Joren";
            txtVerdiensten.Text = "2500";
            btnToevoegen.Click();
            var result = txtWerknemers.Text;
            app.Close();

            Assert.Matches("Synaeve.*Joren.*2500,00", result);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var lblAchternaam = UiHelper.GetLabel(window, "lblAchternaam");
            var lblVoornaam = UiHelper.GetLabel(window, "lblVoornaam");
            var lblVerdiensten = UiHelper.GetLabel(window, "lblVerdiensten");
            var btnToevoegen = UiHelper.GetButton(window, "btnToevoegen");
            var txtAchternaam = UiHelper.GetTextBox(window, "txtAchternaam");
            var txtVoornaam = UiHelper.GetTextBox(window, "txtVoornaam");
            var txtVerdiensten = UiHelper.GetTextBox(window, "txtVerdiensten");
            var txtWerknemers = UiHelper.GetTextBox(window, "txtWerknemers");

            txtAchternaam.Text = "Synaeve";
            txtVoornaam.Text = "Joren";
            txtVerdiensten.Text = "2500";
            btnToevoegen.Click();
            txtAchternaam.Text = "Verlooy";
            txtVoornaam.Text = "Joeri";
            txtVerdiensten.Text = "1000";
            btnToevoegen.Click();

            var result = txtWerknemers.Text;
            app.Close();

            Assert.Matches("Synaeve.*Joren.*2500,00.*\nVerlooy.*Joeri.*1000,00.*", result);
        }
    }
}