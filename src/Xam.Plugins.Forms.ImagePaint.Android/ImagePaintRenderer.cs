using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xam.Plugins.Forms.ImagePaint;
using Xam.Plugins.Forms.ImagePaint.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRendererAttribute(typeof(ImagePaint), typeof(ImagePaintRenderer))]
namespace Xam.Plugins.Forms.ImagePaint.Droid
{
    public class ImagePaintRenderer : ImageRenderer
    {
        public static void Init()
        {
        }

        public ImagePaintRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            SetTint();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ImagePaint.ImageColorProperty.PropertyName || e.PropertyName == ImagePaint.SourceProperty.PropertyName)
                SetTint();
        }

        void SetTint()
        {
            if (Control == null || Element == null)
                return;

            if (((ImagePaint)Element).ImageColor.Equals(Xamarin.Forms.Color.Transparent))
            {
                //Turn off tinting

                if (Control.ColorFilter != null)
                    Control.ClearColorFilter();

                return;
            }

            //Apply tint color
            var colorFilter = new PorterDuffColorFilter(((ImagePaint)Element).ImageColor.ToAndroid(), PorterDuff.Mode.SrcIn);
            Control.SetColorFilter(colorFilter);
        }
    }
}
