using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xam.Plugins.Forms.ImagePaint
{
    public class ImagePaint : Image
    {
        #region Events
        public event EventHandler Clicked;
        #endregion Events

        #region ImageColor
        public static readonly BindableProperty ImageColorProperty =
        BindableProperty.Create(nameof(ImageColor),
                                typeof(Color),
                                typeof(ImagePaint),
                                Color.Black);

        public Color ImageColor
        {
            get { return (Color)GetValue(ImageColorProperty); }
            set { SetValue(ImageColorProperty, value); }
        }
        #endregion ImageColor

        #region Command Parameter
        public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create("CommandParameter",
                                typeof(object),
                                typeof(ImagePaint),
                                null);

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { this.SetValue(CommandParameterProperty, value); }
        }
        #endregion Command Parameter

        #region Command
        public static readonly BindableProperty CommandProperty =
        BindableProperty.Create("Command",
                                typeof(ICommand),
                                typeof(ImagePaint),
                                null,
                                BindingMode.TwoWay);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }
        #endregion Command

        public ImagePaint()
        {
            Initialize();
        }

        private void Initialize()
        {
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += ImagePaint_Tapped;
            this.GestureRecognizers.Add(tap);
        }

        private void ImagePaint_Tapped(object sender, System.EventArgs e)
        {
            if (CommandParameter == null)
                ExecuteCommand(sender);
            else
                ExecuteCommand(CommandParameter);
        }

        private void ExecuteCommand(object parameter)
        {
            if (Command != null)
                Command.Execute(parameter);
        }

        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
    }
}
