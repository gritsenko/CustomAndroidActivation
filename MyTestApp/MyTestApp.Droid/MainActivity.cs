using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Content;
using Android.Views;

namespace MyTestApp.Droid
{
	[Activity(
			MainLauncher = true,
			ConfigurationChanges = global::Uno.UI.ActivityHelper.AllConfigChanges,
			WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
		)]

    [IntentFilter(
        new[] {
            Android.Content.Intent.ActionView
        },
        Categories = new[] {
            Android.Content.Intent.CategoryDefault,
            Android.Content.Intent.CategoryBrowsable
        },
        DataMimeType = "*/*",
        DataSchemes = new[] { "content", "file" },
        DataPathPattern = ".*\\.png"
        )]

    public class MainActivity : Windows.UI.Xaml.ApplicationActivity
	{
	}
}

