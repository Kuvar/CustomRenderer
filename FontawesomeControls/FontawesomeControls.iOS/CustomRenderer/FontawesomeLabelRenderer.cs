using System;
using System.Collections.Generic;
using System.Text;
using FontawesomeControls.iOS.CustomRenderer;
using FontawesomeControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(FontawesomeLabel), typeof(FontawesomeLabelRenderer))]
[assembly: ExportRenderer(typeof(FontawesomeButton), typeof(FontawesomeButtonRenderer))]
namespace FontawesomeControls.iOS.CustomRenderer
{
    public class FontawesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;
            Control.Font = UIFont.FromName("FontAwesome", (nfloat)e.NewElement.FontSize);
        }
    }

    public class FontawesomeButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;
            Control.Font = UIFont.FromName("FontAwesome", (nfloat)e.NewElement.FontSize);
        }
    }
}
