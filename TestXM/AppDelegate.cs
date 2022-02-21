using AppKit;
using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestXM
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            AppCenter.LogLevel = LogLevel.Verbose;
            AppCenter.Start("empty", typeof(Analytics), typeof(Crashes));
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
