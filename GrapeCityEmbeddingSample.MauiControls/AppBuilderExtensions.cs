using C1.Maui.Calendar;
using C1.Maui.Grid;

namespace GrapeCityEmbeddingSample.MauiControls;

public static class AppBuilderExtensions
{
	public static MauiAppBuilder UseMauiControls(this MauiAppBuilder builder)
    {
		builder
            //.RegisterCalendarControls()
            .RegisterFlexGridControls();
        return builder;
	}
}