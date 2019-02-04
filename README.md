## Xam.Plugins.Forms.ImagePaint
A simple custom control for painting images in Xamarin Forms.

#### Supported Platforms
The `ImagePaint` control supports native renderer implementations for the following platforms:
- iOS
- Android

#### Screenshot Demo
<p align="center">
<img src="https://github.com/joaomissio/Xam.Plugins.Forms.ImagePaint/blob/master/demo/ScreenShots/control_android.png" alt="Android Screenshot" width="270" height="480">
</p>

#### How to install?
* Available on NuGet: [![NuGet](https://img.shields.io/nuget/v/Xam.Plugins.Forms.ImagePaint.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Plugins.Forms.ImagePaint/)
  *  [https://www.nuget.org/packages/Xam.Plugins.Forms.ImagePaint](https://www.nuget.org/packages/Xam.Plugins.Forms.ImagePaint)
* Install into your .net standard project and Platform projects (Android and iOS).
* Make sure to initialize the renderer in your iOS and Android projects as shown below:

  * In Android project:
    ```
     global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
     ImagePaintRenderer.Init();
    ```
  * In iOS project: 
    ```
     global::Xamarin.Forms.Forms.Init();
     ImagePaintRenderer.Init();
    ```
 
 #### How to use?
- In Xaml:
```
<ContentPage 
    ...
    xmlns:xf="clr-namespace:Xam.Plugins.Forms.ImagePaint;assembly=Xam.Plugins.Forms.ImagePaint.Abstractions"
    ...>
    ...
    <xf:ImagePaint ImageColor="Red" Source="icon.png" />
    ...
</ContentPage>
```
**Bindable Properties**
   * `ImageColor`: Set color of image, image painting can be disabled by setting `ImageColor` to Transparent. This will display the original image.
   * `Command`: Triggers an action in the ViewModel in the click event in the image.
   * `CommandParameter`: Parameter for Command action.

 
