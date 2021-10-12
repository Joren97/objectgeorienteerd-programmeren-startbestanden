using System;
using Xunit;

namespace oefening_01_test
{
    public class UiTest
    {
        private const string _wpfProjectName = "oefening-01";

        [Fact]
        public void KnopGooienHeeftJuisteNaam()
        {
            var app = TestHelper.LoadApp(_wpfProjectName);
            var window = TestHelper.GetWindow(app);
            var button = TestHelper.GetButton(window, "btnGooien");
            app.Close();

            Assert.NotNull(button);
        }

        [Fact]
        public void LabelsHebbenJuisteNaam()
        {
            var app = TestHelper.LoadApp(_wpfProjectName);
            var window = TestHelper.GetWindow(app);
            var lblBlauw = TestHelper.GetLabel(window, "lblBlauw");
            var lblRood = TestHelper.GetLabel(window, "lblRood");
            app.Close();

            Assert.NotNull(lblBlauw);
            Assert.NotNull(lblRood);
        }

        [Fact]
        public void FunctionaliteitGooien()
        {
            var app = TestHelper.LoadApp(_wpfProjectName);
            var window = TestHelper.GetWindow(app);
            var button = TestHelper.GetButton(window, "btnGooien");
            button.Invoke();
            var lblBlauwValue = TestHelper.GetLabelValue(window, "lblBlauw");
            var lblRoodValue = TestHelper.GetLabelValue(window, "lblRood");
            app.Close();

            Assert.InRange(int.Parse(lblBlauwValue), 1, 6);
            Assert.InRange(int.Parse(lblRoodValue), 1, 6);
        }
    }
}