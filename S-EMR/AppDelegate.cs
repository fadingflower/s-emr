using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SEMR.Business;

namespace SEMR
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		
		public override UIWindow Window {
			get;
			set;
		}

		public string DeviceToken {
			get;
			set;
		}

		public static UIStoryboard Storyboard=UIStoryboard.FromName("MainStoryboard",null);
		
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			UIApplication.SharedApplication.SetMinimumBackgroundFetchInterval (UIApplication.BackgroundFetchIntervalMinimum);
			//UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound);
			Settings.ServerURL = "http://192.168.1.231:8000/BusinessSErvice.svc";
			return true;
		}


		public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			this.DeviceToken = deviceToken.Description;

		}
		public override void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			DeviceToken = "";
		}

		public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
//			string sKey = "inAppMessage";
//			string sMessage = userInfo.ObjectForKey((NSObject)sKey).ToString();
//			UIAlertView alert = new UIAlertView ("Notification", sMessage, null, "OK", null);
//			alert.Show ();
		}

		public override void PerformFetch (UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
		{
			UILocalNotification notification = new UILocalNotification();
			notification.FireDate = DateTime.Now.AddSeconds(1);
			notification.AlertAction = "View Alert";
			notification.AlertBody = "Your backgroud fetching alert has fired!";
			UIApplication.SharedApplication.ScheduleLocalNotification(notification);

			completionHandler (UIBackgroundFetchResult.NewData);
		

		}



	}
}

