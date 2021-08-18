using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MvxCriminalIntent.Core;

namespace MvxCriminalIntent.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
