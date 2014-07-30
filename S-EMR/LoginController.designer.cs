// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SEMR
{
	[Register ("LoginController")]
	partial class LoginController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIControl BackgroudView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LoginBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordTxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UserTxt { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BackgroudView != null) {
				BackgroudView.Dispose ();
				BackgroudView = null;
			}
			if (LoginBtn != null) {
				LoginBtn.Dispose ();
				LoginBtn = null;
			}
			if (PasswordTxt != null) {
				PasswordTxt.Dispose ();
				PasswordTxt = null;
			}
			if (UserTxt != null) {
				UserTxt.Dispose ();
				UserTxt = null;
			}
		}
	}
}
