using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Unity;
using Prism.Ioc;
using FinalOptionalApp.ViewModels;
using FinalOptionalApp.Views;

namespace FinalOptionalApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(Navigation.Main);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainTabbedPage>(Navigation.Main);

            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(Navigation.Home);
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>(Navigation.Detail);
        }
    }
}
