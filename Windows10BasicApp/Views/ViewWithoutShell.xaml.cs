using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XamlBrewer.Uwp.AdaptiveTriggerSample.Views;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows10BasicApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewWithoutShell : Page
    {
        public ViewWithoutShell()
        {
            this.InitializeComponent();
        }

        private void ViewButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (Shell));
        }

        private void AppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}
