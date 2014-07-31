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
	[Register ("DoTestController")]
	partial class DoTestController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LNoteButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TestButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LNoteButton != null) {
				LNoteButton.Dispose ();
				LNoteButton = null;
			}
			if (TestButton != null) {
				TestButton.Dispose ();
				TestButton = null;
			}
		}
	}
}
