using System;
using System.Collections.Generic;
using AppKit;
using Foundation;
using Microsoft.AppCenter.Analytics;

namespace TestXM
{
    public partial class ViewController : NSViewController
    {
        int likes = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        partial void OnButtonClick(NSObject sender)
        {
            likes += 1;
            Analytics.TrackEvent("button clicked", new Dictionary<string, string> { ["likes"] = $"{likes}" });

            var button = sender as NSButton;
            button.Title = $"👍 {likes}";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
