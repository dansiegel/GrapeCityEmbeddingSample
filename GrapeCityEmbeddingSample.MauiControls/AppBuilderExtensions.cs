using C1.Maui.Calendar;
using C1.Maui.Grid;
using CommunityToolkit.Maui;

namespace GrapeCityEmbeddingSample.MauiControls;

public static class AppBuilderExtensions
{
	public static MauiAppBuilder UseMauiControls(this MauiAppBuilder builder)
    {
		builder.UseMauiCommunityToolkit()
            //.RegisterCalendarControls()
            .RegisterFlexGridControls();
        return builder;
	}
}