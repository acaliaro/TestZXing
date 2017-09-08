using System;

using Xamarin.Forms;

namespace TestZXing
{
    public class App : Application
    {
        public App()
        {
            Button b = new Button() {Text ="Open scan page" };
            b.Clicked += async (sender, e) => {

                await Application.Current.MainPage.Navigation.PushAsync(new ScanPage());
            };
            // The root page of your application
            var content = new ContentPage
            {
                Title = "TestZXing",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }, b

                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
