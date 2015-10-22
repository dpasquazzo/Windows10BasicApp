using System.Linq;
using Windows10BasicApp.Views;
using XamlBrewer.Uwp.AdaptiveTriggerSample.ViewModels;
using XamlBrewer.Uwp.AdaptiveTriggerSample.Views;

namespace Windows10BasicApp.ViewModels
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            if (!Menu.Any())
            {
                // Build the menu
                Menu.Add(new MenuItem() { Glyph = "", Text = "MainPage", NavigationDestination = typeof(MainPage) });
                Menu.Add(new MenuItem() { Glyph = "", Text = "SecondPage", NavigationDestination = typeof(SecondPage) });
                Menu.Add(new MenuItem() { Glyph = "", Text = "ThirdPage", NavigationDestination = typeof(ThirdPage) });
                Menu.Add(new MenuItem() { Glyph = "", Text = "WithoutShell", NavigationDestination = typeof(ViewWithoutShell) });
            }
        }
    }
}
