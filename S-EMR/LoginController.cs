using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SEMR
{
	partial class LoginController : UIViewController
	{
		public LoginController (IntPtr handle) : base (handle)
		{
		}
	
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
//			BusinessServiceClient client = new BusinessServiceClient ();
//			client.ExecuteBusinessService(
			LoginBtn.TouchUpInside+=(sender, e) => {



				var myStoryboard=AppDelegate.Storyboard;
				UITabBarController mainViewController=myStoryboard.InstantiateViewController("MainViewController") as UITabBarController;
				NavigationController.PushViewController(mainViewController,true);
			};
		}
	}
}
