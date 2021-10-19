using System;
using Xunit;

namespace oefening_01_test
{
    [Collection("Sequential")]
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-01-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var lblLengte = UiHelper.GetLabel(window, "lblLengte");
            var lblPolsomtrek = UiHelper.GetLabel(window, "lblPolsomtrek");
            var lblIdeaalGewicht = UiHelper.GetLabel(window, "lblIdeaalGewicht");
            var txtLengte = UiHelper.GetTextBox(window, "txtLengte");
            var txtPolsomtrek = UiHelper.GetTextBox(window, "txtPolsomtrek");
            var txtIdeaalGewicht = UiHelper.GetTextBox(window, "txtIdeaalGewicht");
            var rbMan = UiHelper.GetRadioButton(window, "rbMan");
            var rbVrouw = UiHelper.GetRadioButton(window, "rbVrouw");
            app.Close();

            Assert.NotNull(btnBereken);
            Assert.NotNull(btnSluiten);
            Assert.NotNull(lblLengte);
            Assert.NotNull(lblPolsomtrek);
            Assert.NotNull(lblIdeaalGewicht);
            Assert.NotNull(txtLengte);
            Assert.NotNull(txtPolsomtrek);
            Assert.NotNull(txtIdeaalGewicht);
            Assert.NotNull(rbMan);
            Assert.NotNull(rbVrouw);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var lblLengte = UiHelper.GetLabel(window, "lblLengte");
            var lblPolsomtrek = UiHelper.GetLabel(window, "lblPolsomtrek");
            var lblIdeaalGewicht = UiHelper.GetLabel(window, "lblIdeaalGewicht");
            var txtLengte = UiHelper.GetTextBox(window, "txtLengte");
            var txtPolsomtrek = UiHelper.GetTextBox(window, "txtPolsomtrek");
            var txtIdeaalGewicht = UiHelper.GetTextBox(window, "txtIdeaalGewicht");
            var rbMan = UiHelper.GetRadioButton(window, "rbMan");
            var rbVrouw = UiHelper.GetRadioButton(window, "rbVrouw");
            txtLengte.Text = "170";
            btnBereken.Click();
            var value = double.Parse(txtIdeaalGewicht.Text);
            app.Close();

            Assert.Equal(63, value);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBereken = UiHelper.GetButton(window, "btnBereken");
            var btnSluiten = UiHelper.GetButton(window, "btnSluiten");
            var lblLengte = UiHelper.GetLabel(window, "lblLengte");
            var lblPolsomtrek = UiHelper.GetLabel(window, "lblPolsomtrek");
            var lblIdeaalGewicht = UiHelper.GetLabel(window, "lblIdeaalGewicht");
            var txtLengte = UiHelper.GetTextBox(window, "txtLengte");
            var txtPolsomtrek = UiHelper.GetTextBox(window, "txtPolsomtrek");
            var txtIdeaalGewicht = UiHelper.GetTextBox(window, "txtIdeaalGewicht");
            var rbMan = UiHelper.GetRadioButton(window, "rbMan");
            var rbVrouw = UiHelper.GetRadioButton(window, "rbVrouw");
            rbVrouw.Click();
            txtLengte.Text = "170";
            txtPolsomtrek.Text = "15";
            btnBereken.Click();
            var value = double.Parse(txtIdeaalGewicht.Text);
            app.Close();

            Assert.Equal(65, value);
        }
    }
}