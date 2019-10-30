﻿using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {
        protected BaseContentPage()
        {
            BindingContext = ViewModel;
            BackgroundColor = Color.FromHex("65859C");
        }

        protected T ViewModel { get; } = new T();

        protected Task OpenBrowser(Uri uri) => Device.InvokeOnMainThreadAsync(() => Browser.OpenAsync(uri));

        protected Task OpenBrowser(string url) => Device.InvokeOnMainThreadAsync(() => Browser.OpenAsync(url));
    }
}