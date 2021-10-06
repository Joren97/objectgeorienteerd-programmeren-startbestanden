using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_01_test
{
    public static class TestHelper
    {
        public static string GetExePath(string v)
        {
            string myPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string myDir = System.IO.Path.GetDirectoryName(myPath);
            string path = System.IO.Path.Combine(myDir, v);
            return path;
        }

        private static AutomationElement GetAutomationElement(Window window, string name)
        {
            var element = window.FindFirstDescendant(x => x.ByName(name));
            if (element == null)
            {
                element = window.FindFirstDescendant(x => x.ByAutomationId(name));
            }

            return element;
        }

        public static Window GetWindow(FlaUI.Core.Application app, string windowName = null)
        {
            using (var automation = new UIA3Automation())
            {
                if (string.IsNullOrWhiteSpace(windowName))
                    return app.GetMainWindow(automation);
            }

            return null;
        }

        public static FlaUI.Core.Application LoadApp(string v)
        {
            var exe = GetExePath(v);
            return FlaUI.Core.Application.Launch(exe);
        }

        public static string GetLabelValue(Window window, string name)
        {
            var element = GetAutomationElement(window, name);
            return element.AsLabel().Text;
        }

        public static Button GetButton(Window window, string v)
        {
            return GetAutomationElement(window, v).AsButton();
        }

        public static Label GetLabel(Window window, string v)
        {
            return GetAutomationElement(window, v).AsLabel();
        }
    }
}