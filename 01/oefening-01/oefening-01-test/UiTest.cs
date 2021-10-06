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
            var label1 = TestHelper.GetLabel(window, "lblBlauw");
            var label2 = TestHelper.GetLabel(window, "lblRood");
            app.Close();

            Assert.NotNull(label1);
            Assert.NotNull(label2);
        }
    }
}