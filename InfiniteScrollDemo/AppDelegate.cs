﻿using Foundation;
using UIKit;

namespace InfiniteScrollDemo
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {

        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method


            this.Window = new UIWindow(UIScreen.MainScreen.Bounds);
            var viewController = new ViewController();
            var navigationController = new UINavigationController(viewController);
            this.Window.RootViewController = navigationController;
            this.Window.MakeKeyAndVisible();

            return true;
        }
    }
}

