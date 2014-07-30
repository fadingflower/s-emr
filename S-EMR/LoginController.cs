using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using MonoTouch.ObjCRuntime;

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
			UserTxt.EditingDidEndOnExit += (sender, e) => {
				PasswordTxt.BecomeFirstResponder();
			};
			PasswordTxt.EditingDidEndOnExit+=(sender, e) => {
				ResignFirstResponder();
				LoginBtn.SendActionForControlEvents(UIControlEvent.TouchUpInside);
			};
			BackgroudView.TouchDown += (sender, e) => {
				Selector selector=new Selector("resignFirstResponder");
				UIApplication.SharedApplication.SendAction(selector,null,null,null);
			};

		}
	}
}
