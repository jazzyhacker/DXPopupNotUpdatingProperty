using CommunityToolkit.Maui;
using DevExpress.Maui;
using DevExpress.Maui.Core;
using DXPopupNotUpdatingProperty.ViewModels;
using Microsoft.Extensions.Logging;

namespace DXPopupNotUpdatingProperty
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseDevExpress(useLocalization: false)
                .UseDevExpressCharts()
                .UseDevExpressCollectionView()
                .UseDevExpressControls()
                .UseDevExpressDataGrid()
                .UseDevExpressDataGridExport()
                .UseDevExpressEditors()
                .UseDevExpressGauges()
                .UseDevExpressScheduler()
                .UseDevExpressTreeView()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();

            return builder.Build();
        }
    }
}
