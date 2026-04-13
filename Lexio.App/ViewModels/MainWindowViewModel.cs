using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Lexio.App.ViewModels;

public partial class MainWindowViewModel : ObservableObject {
    [ObservableProperty] private ObservableObject _currentPage;

    public MainWindowViewModel() {
        _currentPage = new HomeViewModel();
    }

    [RelayCommand]
    private void GoHome() => CurrentPage = new HomeViewModel();

    [RelayCommand]
    private void GoSettings() => CurrentPage = new SettingsViewModel();
}