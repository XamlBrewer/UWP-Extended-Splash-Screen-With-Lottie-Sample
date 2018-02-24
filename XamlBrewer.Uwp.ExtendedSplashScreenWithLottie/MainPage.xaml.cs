using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ExtendedSplashScreenWithLottie
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Adjust the speed of the animation.
            // Does not work declaratively for now.
            MainpageAnimation.Speed = 3F;
        }

        private void RateButton_Click(object sender, RoutedEventArgs e)
        {
            // Replay the animation.
            MainpageAnimation.PlayAnimation();
        }
    }
}
