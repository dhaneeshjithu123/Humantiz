using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Humantiz.CustomControls;
using Humantiz.Droid.Renderer;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]

namespace Humantiz.Droid.Renderer
{
    public class CustomWebViewRenderer : WebViewRenderer
    {

        public CustomWebViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                if (!customWebView.IsPdf)
                    Control.LoadUrl(customWebView.Uri);
                else
                    Control.LoadUrl("https://drive.google.com/viewerng/viewer?embedded=true&url=" + customWebView.Uri);
            }
        }

    }
}