using System;
using Xunit;

namespace oefening_01_test
{
    public class UiTests
    {
        private const string _wpfProjectName = "oefening-01-wpf";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnGooien = UiHelper.GetButton(window, "btnGooien");
            var lblBlauw = UiHelper.GetLabel(window, "lblBlauw");
            var lblRood = UiHelper.GetLabel(window, "lblRood");
            app.Close();

            Assert.NotNull(btnGooien);
            Assert.NotNull(lblBlauw);
            Assert.NotNull(lblRood);
        }

        [Fact]
        public void CorrecteFunctionaliteit()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var btnGooien = UiHelper.GetButton(window, "btnGooien");
            btnGooien.Click();
            var lblBlauwValue = UiHelper.GetLabelValue(window, "lblBlauw");
            var lblRoodValue = UiHelper.GetLabelValue(window, "lblRood");
            app.Close();

            Assert.InRange(int.Parse(lblBlauwValue), 1, 6);
            Assert.InRange(int.Parse(lblRoodValue), 1, 6);
        }
    }
}