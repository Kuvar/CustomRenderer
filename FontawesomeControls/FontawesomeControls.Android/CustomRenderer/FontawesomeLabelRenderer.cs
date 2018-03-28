using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using FontawesomeControls.Droid.CustomRenderer;
using FontawesomeControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(FontawesomeLabel), typeof(FontawesomeLabelRenderer))]
[assembly: ExportRenderer(typeof(FontawesomeButton), typeof(FontawesomeButtonRenderer))]
namespace FontawesomeControls.Droid.CustomRenderer
{
    public class FontawesomeLabelRenderer : LabelRenderer
    {
        public FontawesomeLabelRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                AwesomeUtil.CheckAndSetTypeFace(Control);
        }
    }

    public class FontawesomeButtonRenderer : ButtonRenderer
    {
        public FontawesomeButtonRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                AwesomeUtil.CheckAndSetTypeFace(Control);
        }
    }

    internal static class AwesomeUtil
    {
        public static void CheckAndSetTypeFace(TextView view)
        {
            if (view.Text.Length == 0) return;
            var text = view.Text;

            var font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "fontawesome.ttf");
            view.Typeface = font;
        }
    }
}