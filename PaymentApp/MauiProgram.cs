using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;
using Microsoft.Win32;

namespace PaymentApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMarkup()
                 .ConfigurePages()
                .ConfigureViewModels()
                 .ConfigureHandlers()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Inter-Light.ttf", "InterLight");
                    fonts.AddFont("Inter-Regular.ttf", "InterRegular");
                    fonts.AddFont("Inter-Medium.ttf", "InterMedium");
                    fonts.AddFont("Inter-SemiBold.ttf", "InterSemiBold");
                    fonts.AddFont("Inter-Bold.ttf", "InterBold");
                });

            builder.Services.AddHybridWebView();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }



        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {


            builder.Services.AddTransient<SavePaymentCardView>();
            builder.Services.AddTransient<BaseView>();


            return builder;
        }

        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {

            builder.Services.AddTransient<SavePaymentCardViewModel>();
            builder.Services.AddTransient<BaseViewModel>();



            return builder;
        }


        public static MauiAppBuilder ConfigureHandlers(this MauiAppBuilder builder)
        {
            return builder.ConfigureMauiHandlers(handlers =>
            {

#if ANDROID
                  Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
                  {
                      handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());

                  });

                   Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
                  {
                      handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());

                  });

                  Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
                  {
                      handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());

                  });
#endif
            });


        }
    }
}
