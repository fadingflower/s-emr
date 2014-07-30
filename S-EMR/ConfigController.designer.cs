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
	[Register ("ConfigController")]
	partial class ConfigController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField ServerURLTxt { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ServerURLTxt != null) {
				ServerURLTxt.Dispose ();
				ServerURLTxt = null;
			}
		}
	}
}
