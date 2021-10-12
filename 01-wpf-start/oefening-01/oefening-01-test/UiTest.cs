using System;
using Xunit;

namespace oefening_01_test
{
    public class UiTest
    {
        private const string _wpfProjectName = "oefening-01";

        [Fact]
        public void ControlsHebbenJuisteNaam()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var button = UiHelper.GetButton(window, "btnGooien");
            var lblBlauw = UiHelper.GetLabel(window, "lblBlauw");
            var lblRood = UiHelper.GetLabel(window, "lblRood");
            app.Close();

            Assert.NotNull(button);
            Assert.NotNull(lblBlauw);
            Assert.NotNull(lblRood);
        }

        [Fact]
        public void CorrecteFunctionaliteit()
        {
            var app = UiHelper.LoadApp(_wpfProjectName);
            var window = UiHelper.GetWindow(app);
            var button = UiHelper.GetButton(window, "btnGooien");
            button.Invoke();
            var lblBlauwValue = UiHelper.GetLabelValue(window, "lblBlauw");
            var lblRoodValue = UiHelper.GetLabelValue(window, "lblRood");
            app.Close();

            Assert.InRange(int.Parse(lblBlauwValue), 1, 6);
            Assert.InRange(int.Parse(lblRoodValue), 1, 6);
        }
    }
}