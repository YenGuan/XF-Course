﻿using Prism.Unity;
using PrismUnityApp1.Views;

namespace PrismUnityApp1
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MDPage/NaviPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MDPage>();
            Container.RegisterTypeForNavigation<NaviPage>();
        }
    }
}
