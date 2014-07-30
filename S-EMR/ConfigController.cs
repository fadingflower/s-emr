using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace SEMR
{
	partial class ConfigController : UIViewController
	{
		public ConfigController (IntPtr handle) : base (handle)
		{


		}

		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();
			ServerURLTxt.Text = Settings.ServerURL;
			ServerURLTxt.EditingChanged+=(object sender, EventArgs e) => {
				Settings.ServerURL=ServerURLTxt.Text;

			};
			ServerURLTxt.EditingDidEndOnExit += (sender, e) => {
				ResignFirstResponder ();
			};
		}

	}
}
