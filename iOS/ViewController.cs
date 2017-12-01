using System;

using UIKit;

namespace MyFirstXamarinApp.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                //var title = string.Format("{0} clicks!", Common.addCounts(count));
                //Button.SetTitle(title, UIControlState.Normal);

                //open munabees.com in navigator or in webview
                //Common.goToWebsite();
                UIApplication.SharedApplication.OpenUrl(new Foundation.NSUrl("http://www.munabees.com"));
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
