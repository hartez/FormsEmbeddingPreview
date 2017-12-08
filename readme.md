# Sample for Xamarin.Forms Native Forms Preview

I'll add a link to the blog post when it's up

This sample demonstrates embedding a Xamarin.Forms page in UWP, iOS, and Android applications. It uses [Charles Petzold's Tip Calculator sample][2].  

**NOTE:** This is an preview and not all features/APIs have been finalized.

## Get the 3.0-preview NuGet
This is very early and not merged into Xamarin.Forms master. To get the package, add this feed to your NuGet sources:
* Add the source: <code>https://www.myget.org/F/xamarinforms-dev/api/v3/index.json</code>
* Check Pre-Release
* Select and install the package with the feature name "Embedding". <code>3.0.0.101-embeddingpreview</code>

## UWP

![Navigating to the embedded Forms page on UWP](https://raw.githubusercontent.com/hartez/FormsEmbeddingPreview/master/images/uwp.gif)

## iOS

![Navigating to the embedded Forms page on iOS](https://raw.githubusercontent.com/hartez/FormsEmbeddingPreview/master/images/ios.gif)

## Android

![Navigating to the embedded Forms page on Android](https://raw.githubusercontent.com/hartez/FormsEmbeddingPreview/master/images/android.gif)

[2]: https://github.com/xamarin/xamarin-forms-samples/tree/master/TipCalc
