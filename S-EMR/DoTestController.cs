using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SEMR
{
	partial class DoTestController : UIViewController
	{
		public bool BackgroudFetchTest { get; set; }
		public DoTestController (IntPtr handle) : base (handle)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			LNoteButton.TouchUpInside+=(object sender, EventArgs e) => {
				UILocalNotification notification = new UILocalNotification();
				notification.FireDate = DateTime.Now.AddSeconds(1);
				notification.AlertAction = "View Alert";
				notification.AlertBody = "Your submited alert has fired!";
				UIApplication.SharedApplication.ScheduleLocalNotification(notification);
				UIAlertView alert = new UIAlertView ("S-EMR", "Notification has been pushed", null, "OK", null);
				alert.Show();
			};


		}

	}
}
