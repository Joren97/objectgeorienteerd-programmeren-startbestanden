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
            var btnBerekenen = UiHelper.GetButton(window, "btnBerekenen");
            var btnAfsluiten = UiHelper.GetButton(window, "btnAfsluiten");
            var lblBedrag = UiHelper.GetLabel(window, "lblBedrag");
            var lblBedragInclBtw = UiHelper.GetLabel(window, "lblBedragInclBtw");
            var txtBedrag = UiHelper.GetTextBox(window, "txtBedrag");
            var txtBedragInclBtw = UiHelper.GetTextBox(window, "txtBedragInclBtw");
            var rb0 = UiHelper.GetRadioButton(window, "rb0");
            var rb6 = UiHelper.GetRadioButton(window, "rb6");
            var rb12 = UiHelper.GetRadioButton(window, "rb12");
            var rb21 = UiHelper.GetRadioButton(window, "rb21");
            app.Close();

            Assert.NotNull(btnBerekenen);
            Assert.NotNull(btnAfsluiten);
            Assert.NotNull(lblBedrag);
            Assert.NotNull(lblBedragInclBtw);
            Assert.NotNull(txtBedrag);
            Assert.NotNull(txtBedragInclBtw);
            Assert.NotNull(rb0);
            Assert.NotNull(rb6);
            Assert.NotNull(rb12);
            Assert.NotNull(rb21);
        }

        [Fact]
        public void CorrecteFunctionaliteit1()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBerekenen");
            var btnAfsluiten = UiHelper.GetButton(window, "btnAfsluiten");
            var lblBedrag = UiHelper.GetLabel(window, "lblBedrag");
            var lblBedragInclBtw = UiHelper.GetLabel(window, "lblBedragInclBtw");
            var txtBedrag = UiHelper.GetTextBox(window, "txtBedrag");
            var txtBedragInclBtw = UiHelper.GetTextBox(window, "txtBedragInclBtw");
            var rb0 = UiHelper.GetRadioButton(window, "rb0");
            var rb6 = UiHelper.GetRadioButton(window, "rb6");
            var rb12 = UiHelper.GetRadioButton(window, "rb12");
            var rb21 = UiHelper.GetRadioButton(window, "rb21");
            txtBedrag.Text = "60";
            rb0.Click();
            btnBerekenen.Click();
            var value = double.Parse(txtBedragInclBtw.Text);
            app.Close();
            Assert.Equal(60, value);
        }

        [Fact]
        public void CorrecteFunctionaliteit2()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBerekenen");
            var btnAfsluiten = UiHelper.GetButton(window, "btnAfsluiten");
            var lblBedrag = UiHelper.GetLabel(window, "lblBedrag");
            var lblBedragInclBtw = UiHelper.GetLabel(window, "lblBedragInclBtw");
            var txtBedrag = UiHelper.GetTextBox(window, "txtBedrag");
            var txtBedragInclBtw = UiHelper.GetTextBox(window, "txtBedragInclBtw");
            var rb0 = UiHelper.GetRadioButton(window, "rb0");
            var rb6 = UiHelper.GetRadioButton(window, "rb6");
            var rb12 = UiHelper.GetRadioButton(window, "rb12");
            var rb21 = UiHelper.GetRadioButton(window, "rb21");
            txtBedrag.Text = "60";
            rb6.Click();
            btnBerekenen.Click();
            var value = double.Parse(txtBedragInclBtw.Text);
            app.Close();
            Assert.Equal(63.60, value);
        }

        [Fact]
        public void CorrecteFunctionaliteit3()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBerekenen");
            var btnAfsluiten = UiHelper.GetButton(window, "btnAfsluiten");
            var lblBedrag = UiHelper.GetLabel(window, "lblBedrag");
            var lblBedragInclBtw = UiHelper.GetLabel(window, "lblBedragInclBtw");
            var txtBedrag = UiHelper.GetTextBox(window, "txtBedrag");
            var txtBedragInclBtw = UiHelper.GetTextBox(window, "txtBedragInclBtw");
            var rb0 = UiHelper.GetRadioButton(window, "rb0");
            var rb6 = UiHelper.GetRadioButton(window, "rb6");
            var rb12 = UiHelper.GetRadioButton(window, "rb12");
            var rb21 = UiHelper.GetRadioButton(window, "rb21");
            txtBedrag.Text = "60";
            rb12.Click();
            btnBerekenen.Click();
            var value = double.Parse(txtBedragInclBtw.Text);
            app.Close();
            Assert.Equal(67.20, value);
        }

        [Fact]
        public void CorrecteFunctionaliteit4()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnBerekenen = UiHelper.GetButton(window, "btnBerekenen");
            var btnAfsluiten = UiHelper.GetButton(window, "btnAfsluiten");
            var lblBedrag = UiHelper.GetLabel(window, "lblBedrag");
            var lblBedragInclBtw = UiHelper.GetLabel(window, "lblBedragInclBtw");
            var txtBedrag = UiHelper.GetTextBox(window, "txtBedrag");
            var txtBedragInclBtw = UiHelper.GetTextBox(window, "txtBedragInclBtw");
            var rb0 = UiHelper.GetRadioButton(window, "rb0");
            var rb6 = UiHelper.GetRadioButton(window, "rb6");
            var rb12 = UiHelper.GetRadioButton(window, "rb12");
            var rb21 = UiHelper.GetRadioButton(window, "rb21");
            txtBedrag.Text = "60";
            rb21.Click();
            btnBerekenen.Click();
            var value = double.Parse(txtBedragInclBtw.Text);
            app.Close();
            Assert.Equal(72.60, value);
        }
    }
}