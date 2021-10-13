using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace oefening_03_test
{
    public static class UiHelper
    {
        public static string GetExePath(string v)
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());

            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }

            FileInfo[] allFiles = directory.GetFiles("*.*", SearchOption.AllDirectories);

            return allFiles.First(x => x.FullName.Contains($"{v}.exe")).FullName;
        }

        internal static TextBox GetTextBox(Window window, string v)
        {
            return GetAutomationElement(window, v).AsTextBox();
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