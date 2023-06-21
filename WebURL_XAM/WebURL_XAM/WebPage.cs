using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WebURL_XAM
{
    public class WebPage: ContentPage
    {
       public WebPage()
        {
            var browser = new WebView();
            browser.Source = "https://xamplify.com/";
            Content = browser;
        }
    }
}
