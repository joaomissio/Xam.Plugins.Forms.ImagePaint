using Xamarin.Forms;

namespace Xam.Plugins.Forms.ImagePaint
{
    public class ImagePaint : Image
    {
        public static readonly BindableProperty ImageColorProperty = BindableProperty.Create(nameof(ImageColor), typeof(Color), typeof(ImagePaint), Color.Black);

        public Color ImageColor
        {
            get { return (Color)GetValue(ImageColorProperty); }
            set { SetValue(ImageColorProperty, value); }
        }
    }
}
