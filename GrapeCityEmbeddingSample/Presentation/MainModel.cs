using CommunityToolkit.Mvvm.ComponentModel;

namespace GrapeCityEmbeddingSample.Presentation;

public partial class MainViewModel : ObservableObject
{
	private INavigator _navigator;

	public MainViewModel(
		IStringLocalizer localizer,
		IOptions<AppConfig> appInfo,
		INavigator navigator)
	{
		_navigator = navigator;
		Title = "Main";
		Title += $" - {localizer["ApplicationName"]}";
		Title += $" - {appInfo?.Value?.Environment}";

		
	}

	public string? Title { get; }

	[ObservableProperty]
	private string? name;

	

}
