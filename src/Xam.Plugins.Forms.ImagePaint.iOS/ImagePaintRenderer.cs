
using Xam.Plugins.Forms.ImagePaint;
using Xam.Plugins.Forms.ImagePaint.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(ImagePaint), typeof(ImagePaintRenderer))]

namespace Xam.Plugins.Forms.ImagePaint.iOS
{
    public class ImagePaintRenderer : ImageRenderer
    {
        public static void Init()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            SetTint();
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ImagePaint.ImageColorProperty.PropertyName || e.PropertyName == ImagePaint.SourceProperty.PropertyName)
                SetTint();
        }

        void SetTint()
        {
            if (Control?.Image == null || Element == null)
                return;

            if (((ImagePaint)Element).ImageColor == Color.Transparent)
            {
                //Turn off tinting
                Control.Image = Control.Image.ImageWithRenderingMode(UIKit.UIImageRenderingMode.Automatic);
                Control.TintColor = null;
            }
            else
            {
                //Apply tint color
                Control.Image = Control.Image.ImageWithRenderingMode(UIKit.UIImageRenderingMode.AlwaysTemplate);
                Control.TintColor = ((ImagePaint)Element).ImageColor.ToUIColor();
            }
        }
    }
}