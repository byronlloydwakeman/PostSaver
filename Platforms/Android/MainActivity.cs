using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace PostSaver
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Check if the activity was launched from a share intent
            if (Intent?.Action == Intent.ActionSend && Intent.Type != null)
            {
                HandleSendIntent(Intent);
            }
        }

        private void HandleSendIntent(Intent intent)
        {
            if (intent.Extras != null)
            {
                var sharedText = intent.GetStringExtra(Intent.ExtraText);
                var sharedUri = (Android.Net.Uri)intent.GetParcelableExtra(Intent.ExtraStream);

                // Process the shared text or URI
                if (!string.IsNullOrEmpty(sharedText))
                {
                    // Handle the shared text
                }

                if (sharedUri != null)
                {
                    // Handle the shared URI (e.g., download the content)
                }
            }
        }
    }
}
