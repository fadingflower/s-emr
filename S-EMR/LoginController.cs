using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using MonoTouch.ObjCRuntime;
using SEMR.Business;
using SEMR.Business.DataTables;
using SEMR.Business.Facade;

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
				try
				{
					if(SecurityFacade.AuthenticateUser(UserTxt.Text,PasswordTxt.Text)){
						var myStoryboard=AppDelegate.Storyboard;
						UITabBarController mainViewController=myStoryboard.InstantiateViewController("MainViewController") as UITabBarController;
						NavigationController.PushViewController(mainViewController,true);
					}
					else
					{
						UIAlertView view=new UIAlertView("S-EMR","Login Failed",null,"OK",null);
						view.Show();
					}
				}
				catch(Exception ex)
				{
					UIAlertView view=new UIAlertView("S-EMR",ex.ToString(),null,"OK",null);
					view.Show();
				}

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
